using Pointer.Core.Types;
using Pointer.Database.Entities;
using Pointer.Database.Transfer;

namespace Pointer.Database.Mappers;

/// <summary>
/// Provides mapping methods to convert native Pointer ControlObjectSections to different states.
/// </summary>
public class ControlObjectSectionMapper : IMapper<ControlObjectSectionEntity, ControlObjectSectionDto, ControlObjectSection>
{
    public void DtoToDto(ControlObjectSectionDto recipient, ControlObjectSectionDto source)
    {
        throw new NotImplementedException();
    }

    public ControlObjectSectionEntity DtoToEntity(ControlObjectSectionDto dto)
    {
        return new ControlObjectSectionEntity
        (
            dto.Id,
            dto.ControlObjectId,
            dto.Name,
            dto.StartPage,
            dto.EndPage
        );
    }

    public ControlObjectSection DtoToModel(ControlObjectSectionDto dto)
    {
        throw new NotImplementedException();
    }

    public ControlObjectSectionDto EntityToDto(ControlObjectSectionEntity entity)
    {
        ControlObjectSectionDto Dto = new ControlObjectSectionDto
        (
            entity.ControlObjectId,
            entity.Name,
            entity.StartPage,
            entity.EndPage
        );
        Dto.Id = entity.Id;
        return Dto;
    }

    public void EntityToEntity(ControlObjectSectionEntity recipient, ControlObjectSectionEntity source)
    {
        throw new NotImplementedException();
    }

    public ControlObjectSectionDto ModelToDto(ControlObjectSection model)
    {
        throw new NotImplementedException();
    }

    public void ModelToModel(ControlObjectSection recipient, ControlObjectSection source)
    {
        throw new NotImplementedException();
    }
}