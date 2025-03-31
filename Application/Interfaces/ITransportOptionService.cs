using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Interfaces;
public interface ITransportOptionService
{
    Task<IEnumerable<TransportOptionDto>> GetAllTransportOptionsAsync();
    Task<TransportOptionDto?> GetTransportOptionByIdAsync(int id);
    Task<TransportOptionDto?> AddTransportOptionAsync(TransportOptionDto transportOptionDto);
    Task<TransportOptionDto?> UpdateTransportOptionAsync(int id, TransportOptionDto transportOptionDto);
    Task<bool> DeleteTransportOptionAsync(int id);
}
