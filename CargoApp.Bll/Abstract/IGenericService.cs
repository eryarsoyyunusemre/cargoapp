using MongoDB.Bson;

namespace CargoApp.Bll.Abstract;

public interface IGenericService<T> where T :class 
{
    Task TCreateAsync(T entity);
    Task TUpdateAsync(T entity);
    Task TDeleteAsync(ObjectId id);
    Task<List<T>> TGetListAsync();
    Task<T> TGetByIdAsync(ObjectId id);
}