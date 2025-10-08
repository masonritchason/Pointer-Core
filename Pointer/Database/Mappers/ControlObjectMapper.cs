using Pointer.Core.Models;
using Pointer.Database.Entities;
using Pointer.Database.Transfer;

namespace Pointer.Database.Mappers;

/// <summary>
/// Provides mapping methods to convert native Pointer ControlObjects to different states.
/// </summary>
public class ControlObjectMapper : IMapper<ControlObjectEntity, ControlObjectDto, ControlObject>
{
    public void DtoToDto(ControlObjectDto recipient, ControlObjectDto source)
    {
        throw new NotImplementedException();
    }

    public ControlObjectEntity DtoToEntity(ControlObjectDto dto)
    {
        return new ControlObjectEntity
        (
            dto.Id,
            dto.FilePath,
            dto.Type,
            dto.MajorRevision,
            dto.MinorRevision,
            dto.Name,
            dto.Notes
        );
    }

    public ControlObject DtoToModel(ControlObjectDto dto)
    {
        throw new NotImplementedException();
    }

    public ControlObjectDto EntityToDto(ControlObjectEntity entity)
    {
        ControlObjectDto Dto = new ControlObjectDto
        (
            entity.FilePath,
            entity.Type,
            entity.MajorRevision,
            entity.MinorRevision,
            entity.Name,
            entity.Notes
        );
        Dto.Id = entity.Id;
        return Dto;
    }

    public void EntityToEntity(ControlObjectEntity recipient, ControlObjectEntity source)
    {
        throw new NotImplementedException();
    }

    public ControlObjectDto ModelToDto(ControlObject model)
    {
        throw new NotImplementedException();
    }

    public void ModelToModel(ControlObject recipient, ControlObject source)
    {
        throw new NotImplementedException();
    }
}