namespace Places.Infrastructure.Repositories;

public class LabelRepository : Repository<Label>, ILabelRepository
{
    public LabelRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
    }
}