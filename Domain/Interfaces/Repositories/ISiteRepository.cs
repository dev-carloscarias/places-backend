namespace Places.Domain.Interfaces.Repositories
{
    public interface ISiteRepository : IRepository<Site>
    {
        Task<IEnumerable<Site>> FindSiteByTitle(string titlePrefix, int limit = 6);
    }
}
