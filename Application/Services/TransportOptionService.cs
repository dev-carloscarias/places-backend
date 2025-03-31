using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Places.Application.Services;
public class TransportOptionService : ITransportOptionService
{
    private readonly ITransportOptionRepository _repository;
    private readonly IMapper _mapper;

    public TransportOptionService(ITransportOptionRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<TransportOptionDto>> GetAllTransportOptionsAsync()
    {
        var transportOptions = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<TransportOptionDto>>(transportOptions);
    }

    public async Task<TransportOptionDto?> GetTransportOptionByIdAsync(int id)
    {
        var transportOption = await _repository.GetByIdAsync(id);
        return _mapper.Map<TransportOptionDto?>(transportOption);
    }

    public async Task<TransportOptionDto?> AddTransportOptionAsync(TransportOptionDto transportOptionDto)
    {
        var entity = _mapper.Map<TransportOption>(transportOptionDto);
        var addedEntity = await _repository.AddAsync(entity);
        return _mapper.Map<TransportOptionDto>(addedEntity);
    }

    public async Task<TransportOptionDto?> UpdateTransportOptionAsync(int id, TransportOptionDto transportOptionDto)
    {
        var existingEntity = await _repository.GetByIdAsync(id);
        if (existingEntity == null) return null;

        existingEntity.Name = transportOptionDto.Name;
        existingEntity.ImageUrl = transportOptionDto.ImageUrl;
        existingEntity.IsActive = transportOptionDto.IsActive;

        var updatedEntity = await _repository.UpdateAsync(existingEntity);
        return _mapper.Map<TransportOptionDto>(updatedEntity);
    }

    public async Task<bool> DeleteTransportOptionAsync(int id)
    {
        await _repository.DeletePermanentlyAsync(id);
        return true;
    }
}
