namespace Places.Infrastructure.Repositories;

public class TranslateRepository : Repository<Translate>, ITranslateRepository
{
    public TranslateRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
    }
}