using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Interfaces;
public interface IRegionService
{
    Task<Region> Create(Region region);
    Task<Region?> GetById(int id);
    Task<IEnumerable<Region>> GetAll();
    Task<Region> Update(Region region);
    Task Delete(int id);
    Task<IEnumerable<Region>> GetByCountryId(int countryId);

}