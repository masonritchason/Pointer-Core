namespace Pointer.Database.Mappers;

/// <summary>
/// Provides mapping methods to convert native Pointer objects to different states.
/// </summary>
/// <typeparam name="TEntity"></typeparam>
/// <typeparam name="TDto"></typeparam>
/// <typeparam name="TModel"></typeparam>
public interface IMapper<TEntity, TDto, TModel>
{
    /// <summary>
    /// Maps values of an object of type TEntity to an object of type TDto.
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    TDto EntityToDto(TEntity entity);

    /// <summary>
    /// Maps values of an object of type TEntity to an object of type TEntity.
    /// </summary>
    /// <remarks>
    /// Effectively shallow copies source to recipient.
    /// </remarks>
    /// <param name="recipient"></param>
    /// <param name="source"></param>
    void EntityToEntity(TEntity recipient, TEntity source);

    /// <summary>
    /// Maps values of an object of type TModel to an object of type TDto.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    TDto ModelToDto(TModel model);

    /// <summary>
    /// Maps values of an object of type TModel to an object of type TModel.
    /// </summary>
    /// <remarks>
    /// Effectively shallow copies source to recipient.
    /// </remarks>
    /// <param name="recipient"></param>
    /// <param name="source"></param>
    void ModelToModel(TModel recipient, TModel source);

    /// <summary>
    /// Maps values of an object of type TDto to an object of type TEntity.
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    TEntity DtoToEntity(TDto dto);

    /// <summary>
    /// Maps values of an object of type TDto to an object of type TModel.
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    TModel DtoToModel(TDto dto);

    /// <summary>
    /// Maps values of an object of type TDto to an object of type TDto.
    /// </summary>
    /// <remarks>
    /// Effectively shallow copies source to recipient.
    /// </remarks>
    /// <param name="recipient"></param>
    /// <param name="source"></param>
    void DtoToDto(TDto recipient, TDto source);
}