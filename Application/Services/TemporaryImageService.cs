using Microsoft.AspNetCore.Http;
using Places.Domain.Common;
using Places.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        var files = formCollection.Files;

        foreach (var file in files)
        {
            if (file.Length > 0)
            {
                using var ms = new MemoryStream();
                await file.CopyToAsync(ms);
                var fileBytes = ms.ToArray();

                var description = formCollection["description"].ToString();
                var section = formCollection["section"].ToString();
                var fileOrderStr = formCollection["fileOrder"].ToString();
                var dataFileTypeStr = formCollection["dataFileType"].ToString();
                var dataTypeExtensionStr = formCollection["dataTypeExtension"].ToString();

                var filePath = await _dataService.UploadBlobFile($"Sites/{Guid.NewGuid()}/{Guid.NewGuid().ToString()}.{dataTypeExtensionStr}", fileBytes);

                int.TryParse(fileOrderStr, out int fileOrder);
                Enum.TryParse<DataFileType>(dataFileTypeStr, out var dataFileType);
                Enum.TryParse<DataTypeExtension>(dataTypeExtensionStr, out var dataTypeExtension);

                var temporaryImage = new TemporaryImage
                {
                    UserId = userId,
                    Path = filePath,
                    Description = description,
                    Section = section,
                    FileOrder = fileOrder,
                    DataFileType = dataFileType,
                    DataTypeExtension = dataTypeExtension,
                    CreatedAt = DateTimeOffset.Now,
                    SessionId = sessionId,
                };

                await _temporaryImageRepository.AddAsync(temporaryImage);
                uploadedImages.Add(temporaryImage);
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
