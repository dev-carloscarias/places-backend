namespace Places.Application.Services;

public class DataFileService : IDataFileService
{
    private readonly IDataFileRepository _dataFileRepository;

    public DataFileService(IDataFileRepository dataFileRepository)
    {
        _dataFileRepository = dataFileRepository;
    }

    public async Task<DataFile> Create(DataFile model)
    {
        return await _dataFileRepository.AddAsync(model);
    }

    public async Task Delete(int id)
    {
        var original = await _dataFileRepository.GetByIdAsync(id);

        if (original is not null)
        {
            await _dataFileRepository.RemoveAsync(original);
            return;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<DataFile> Edit(DataFile model)
    {
        var id = model.Id;
        var original = await _dataFileRepository.GetByIdAsync(id);

        if (original is not null)
        {
            return await _dataFileRepository.UpdateAsync(model);
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<IEnumerable<DataFile>> GetAll()
    {
        return await _dataFileRepository.GetAllAsync();
    }

    public async Task<DataFile> GetById(int id)
    {
        var current = await _dataFileRepository.GetByIdAsync(id);

        if (current is not null)
        {
            return current;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<bool> Any()
    {
        return await _dataFileRepository.AnyAsync();
    }

    public async Task<bool> Any(Expression<Func<DataFile, bool>> predicate)
    {
        return await _dataFileRepository.AnyAsync(predicate);
    }

    public async Task<QueryResult<DataFile>> GetByQueryRequestAsync(QueryRequest queryRequest)
    {
        return await _dataFileRepository.GetByQueryRequestAsync(queryRequest);
    }

    public async Task<IEnumerable<DataFile>> GetByUserIdAsync(int userId)
    {
        return await _dataFileRepository.FindAllAsync(d => d.UserId == userId);
    }
}