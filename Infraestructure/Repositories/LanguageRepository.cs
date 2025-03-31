namespace Places.Infrastructure.Repositories;

public class LanguageRepository : Repository<Language>, ILanguageRepository
{
    public LanguageRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
    }
}