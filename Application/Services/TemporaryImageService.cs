using Microsoft.AspNetCore.Http;
using Places.Domain.Common;
using Places.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Webp;
using SixLabors.ImageSharp.Processing;


namespace Places.Application.Services;
public class TemporaryImageService : ITemporaryImageService
{
    private readonly ITemporaryImageRepository _temporaryImageRepository;
    private readonly IDataService _dataService;

    public TemporaryImageService(ITemporaryImageRepository temporaryImageRepository, IDataService dataService)
    {
        _temporaryImageRepository = temporaryImageRepository;
        _dataService = dataService;
    }

    public async Task<List<TemporaryImage>> GetImagesByUserIdandSessionAsync(int userId, int sessionId)
    {
        return await _temporaryImageRepository.GetTemporaryImagesbyId(userId, sessionId);
    }

    public async Task<Site> LinkImagesToSiteAsync(int userId, int sessionId, Site model)
    {
        var temporaryImages = await _temporaryImageRepository.GetTemporaryImagesbyId(userId, sessionId);

        foreach (var tempImage in temporaryImages)
        {
            var dataFile = new DataFile
            {
                Path = tempImage.Path,
                Description = tempImage.Description,
                Section = tempImage.Section,
                FileOrder = tempImage.FileOrder,
                DataFileType = tempImage.DataFileType,
                DataTypeExtension = tempImage.DataTypeExtension
            };
            model.DataFiles.Add(dataFile);
        }

        foreach (var tempImage in temporaryImages)
        {
            await _temporaryImageRepository.DeletePermanentlyAsync(tempImage.Id);
        }
        return model;
    }
    public async Task<List<TemporaryImage>> AddTemporaryImages(int userId, int sessionId, IFormCollection formCollection)
    {
        var uploadedImages = new List<TemporaryImage>();
        var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif", ".webp" }; // formatos permitidos
        const int maxWidth = 1920;
        const int maxHeight = 1080;

        foreach (var file in formCollection.Files)
        {
 
            var extension = Path.GetExtension(file.FileName).ToLowerInvariant();
            if (!allowedExtensions.Contains(extension))
                continue;

            try
            {
                using var inputStream = file.OpenReadStream();
                using var image = await Image.LoadAsync(inputStream);

                image.Mutate(x =>
                {
                    x.AutoOrient();

                    // Redimensionar si es más grande que el tamaño objetivo
                    if (image.Width > maxWidth || image.Height > maxHeight)
                    {
                        x.Resize(new ResizeOptions
                        {
                            Mode = ResizeMode.Max,
                            Size = new Size(maxWidth, maxHeight)
                        });
                    }
                });

                // Compresión WebP con buena calidad visual
                var encoder = new WebpEncoder
                {
                    Quality = 80 
                };

                using var outputStream = new MemoryStream();
                await image.SaveAsWebpAsync(outputStream, encoder);
                var fileBytes = outputStream.ToArray();

                // Obtener campos
                var description = formCollection["description"].ToString();
                var section = formCollection["section"].ToString();
                var fileOrderStr = formCollection["fileOrder"].ToString();
                var dataFileTypeStr = formCollection["dataFileType"].ToString();

                var filePath = await _dataService.UploadBlobFile($"Sites/{Guid.NewGuid()}/{Guid.NewGuid()}.webp", fileBytes);

                int.TryParse(fileOrderStr, out int fileOrder);
                Enum.TryParse<DataFileType>(dataFileTypeStr, out var dataFileType);

                var temporaryImage = new TemporaryImage
                {
                    UserId = userId,
                    Path = filePath,
                    Description = description,
                    Section = section,
                    FileOrder = fileOrder,
                    DataFileType = dataFileType,
                    DataTypeExtension = DataTypeExtension.Webp,
                    CreatedAt = DateTimeOffset.Now,
                    SessionId = sessionId,
                };

                await _temporaryImageRepository.AddAsync(temporaryImage);
                uploadedImages.Add(temporaryImage);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error procesando archivo {file.FileName}: {ex.Message}");
            }
        }

        return uploadedImages;
    }


    public async Task<TemporaryImage> GetImageByIdAsync(int id)
    {
        return await _temporaryImageRepository.GetByIdAsync(id);
    }

    public async Task DeletePermanentlyAsync(int id)
    {
        await _temporaryImageRepository.DeletePermanentlyAsync(id);
    }

    public async Task UpdateAsync(TemporaryImage image)
    {
        await _temporaryImageRepository.UpdateAsync(image);
    }

}
