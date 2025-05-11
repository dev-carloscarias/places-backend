using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Places.Domain.Entities;

namespace Places.Application.Services;
public class TransportOptionService : ITransportOptionService
{
    private readonly ITransportOptionRepository _repository;
    private readonly IMapper _mapper;
    private readonly IDataService _dataService;

    public TransportOptionService(ITransportOptionRepository repository, IMapper mapper, IDataService dataService)
    {
        _repository = repository;
        _mapper = mapper;
        _dataService = dataService;
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
        var filePath = "";
     
        if(transportOptionDto.ImageUrl != "")
        {
            var extension = transportOptionDto.DataTypeExtension;
            filePath = await _dataService.UploadFile($"0/{Guid.NewGuid().ToString()}.{extension}", transportOptionDto.ImageUrl!);
            transportOptionDto.ImageUrl = filePath;
        }
        var entity = _mapper.Map<TransportOption>(transportOptionDto);
        var addedEntity = await _repository.AddAsync(entity);
        return _mapper.Map<TransportOptionDto>(addedEntity);
    }

    public async Task<TransportOptionDto?> UpdateTransportOptionAsync(int id, TransportOptionDto transportOptionDto)
    {
        var filePath = "";
        var existingEntity = await _repository.GetByIdAsync(id);
        if (existingEntity == null) return null;

        existingEntity.Name = transportOptionDto.Name;
        existingEntity.IsActive = transportOptionDto.IsActive;
        if(existingEntity.ImageUrl != transportOptionDto.ImageUrl && transportOptionDto.ImageUrl != "")
        {
            var extension = transportOptionDto.DataTypeExtension;
            filePath = await _dataService.UploadFile($"0/{Guid.NewGuid().ToString()}.{extension}", transportOptionDto.ImageUrl!);
            transportOptionDto.ImageUrl = filePath;
        }

        existingEntity.ImageUrl = transportOptionDto.ImageUrl;


        var updatedEntity = await _repository.UpdateAsync(existingEntity);
        return _mapper.Map<TransportOptionDto>(updatedEntity);
    }

    public async Task<bool> DeleteTransportOptionAsync(int id)
    {
        await _repository.DeletePermanentlyAsync(id);
        return true;
    }






}
