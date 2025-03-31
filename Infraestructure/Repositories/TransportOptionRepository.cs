using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Infrastructure.Repositories;
public class TransportOptionRepository : Repository<TransportOption>, ITransportOptionRepository
{
    private readonly ApplicationDbContext _context;

    public TransportOptionRepository(ApplicationDbContext appDbContext) : base(appDbContext)
    {
        _context = appDbContext;
    }

    public async Task<TransportOption?> GetByIdAsync(int id)
    {
        return await _context.TransportOptions.FindAsync(id);
    }

    public async Task<TransportOption> AddAsync(TransportOption transportOption)
    {
        _context.TransportOptions.Add(transportOption);
        await _context.SaveChangesAsync();
        return transportOption;
    }

    public async Task<TransportOption> UpdateAsync(TransportOption transportOption)
    {
        _context.TransportOptions.Update(transportOption);
        await _context.SaveChangesAsync();
        return transportOption;
    }

    public async Task DeleteAsync(TransportOption transportOption)
    {
        _context.TransportOptions.Remove(transportOption);
        await _context.SaveChangesAsync();
    }
}
