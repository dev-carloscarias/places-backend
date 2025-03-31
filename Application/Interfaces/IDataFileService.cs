namespace Places.Application.Interfaces;

public interface IDataFileService : IService<DataFile>
{
    Task<IEnumerable<DataFile>> GetByUserIdAsync(int userId);
}