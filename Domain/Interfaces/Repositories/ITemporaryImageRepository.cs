namespace Places.Domain.Interfaces.Repositories;

public interface ITemporaryImageRepository : IRepository<TemporaryImage>
{
    Task<List<TemporaryImage>> GetTemporaryImagesbyId(int userId, int sessionId);
}

