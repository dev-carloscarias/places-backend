namespace Places.Infrastructure.Repositories;

public class DataFileRepository : Repository<DataFile>, IDataFileRepository
{
    public DataFileRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
    }
}