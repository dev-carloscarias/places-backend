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
        var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".bmp" }; // formatos permitidos
        const int maxWidth = 1920;
        const int maxHeight = 1080;
        const long maxFileSizeInBytes = 2 * 1024 * 1024; // 2 MB límite para imagen sin comprimir

        foreach (var file in formCollection.Files)
        {
            if (file.Length == 0 || file.Length > 20 * 1024 * 1024) // rechaza archivos vacíos o >20 MB
                continue;

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

                    // Redimensionar si la imagen es muy grande
                    if (image.Width > maxWidth || image.Height > maxHeight)
                    {
                        x.Resize(new ResizeOptions
                        {
                            Mode = ResizeMode.Max,
                            Size = new Size(maxWidth, maxHeight)
                        });
                    }
                });

                // Elegir calidad basada en tamaño original
                int quality = file.Length > maxFileSizeInBytes ? 70 : 80;

                var encoder = new WebpEncoder
                {
                    Quality = quality
                };

                using var outputStream = new MemoryStream();
                await image.SaveAsWebpAsync(outputStream, encoder);
                var fileBytes = outputStream.ToArray();

                // Obtener campos
                var description = formCollection["description"].ToString();
                var section = formCollection["section"].ToString();
                var fileOrderStr = formCollection["fileOrder"].ToString();
                var dataFileTypeStr = formCollection["dataFileType"].ToString();

                // Subir a blob con extensión .webp
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
                    DataTypeExtension = DataTypeExtension.Webp, // Asumiendo que tienes este enum
                    CreatedAt = DateTimeOffset.Now,
                    SessionId = sessionId,
                };

                await _temporaryImageRepository.AddAsync(temporaryImage);
                uploadedImages.Add(temporaryImage);
            }
            catch (Exception ex)
            {
                // Log o manejar error si la imagen está corrupta o no se pudo procesar
                Console.WriteLine($"Error procesando archivo {file.FileName}: {ex.Message}");
            }
        }
        return uploadedImages;

        //var uploadedImages = new List<TemporaryImage>();

        //var files = formCollection.Files;

        //foreach (var file in files)
        //{
        //    if (file.Length > 0)
        //    {
        //        using var ms = new MemoryStream();
        //        await file.CopyToAsync(ms);
        //        var fileBytes = ms.ToArray();

        //        var description = formCollection["description"].ToString();
        //        var section = formCollection["section"].ToString();
        //        var fileOrderStr = formCollection["fileOrder"].ToString();
        //        var dataFileTypeStr = formCollection["dataFileType"].ToString();
        //        var dataTypeExtensionStr = formCollection["dataTypeExtension"].ToString();

        //        var filePath = await _dataService.UploadBlobFile($"Sites/{Guid.NewGuid()}/{Guid.NewGuid().ToString()}.{dataTypeExtensionStr}", fileBytes);

        //        int.TryParse(fileOrderStr, out int fileOrder);
        //        Enum.TryParse<DataFileType>(dataFileTypeStr, out var dataFileType);
        //        Enum.TryParse<DataTypeExtension>(dataTypeExtensionStr, out var dataTypeExtension);

        //        var temporaryImage = new TemporaryImage
        //        {
        //            UserId = userId,
        //            Path = filePath,
        //            Description = description,
        //            Section = section,
        //            FileOrder = fileOrder,
        //            DataFileType = dataFileType,
        //            DataTypeExtension = dataTypeExtension,
        //            CreatedAt = DateTimeOffset.Now,
        //            SessionId = sessionId,
        //        };

        //        await _temporaryImageRepository.AddAsync(temporaryImage);
        //        uploadedImages.Add(temporaryImage);
        //    }
        //}

        //return uploadedImages;
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
