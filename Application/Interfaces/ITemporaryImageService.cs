using Microsoft.AspNetCore.Http;
using Places.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Interfaces;
public interface ITemporaryImageService
{
    Task<List<TemporaryImage>> AddTemporaryImages(int userId, int sessionId, IFormCollection formCollection);
    Task<List<TemporaryImage>> GetImagesByUserIdandSessionAsync(int userId, int sessionId);
    Task<Site> LinkImagesToSiteAsync(int userId, int sessionId, Site model);

    Task<TemporaryImage> GetImageByIdAsync(int id);

    Task DeletePermanentlyAsync(int id);
    Task UpdateAsync(TemporaryImage image);

}