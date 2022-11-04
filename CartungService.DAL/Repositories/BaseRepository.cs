using CartingService.DAL.Entities;

namespace CartingService.DAL.Repositories;

public abstract class BaseRepository<TEntity> : IRepository<TEntity>
    where TEntity : BaseEntity
{
    protected readonly LiteDatabaseAsync _context = null!;
    protected readonly ILiteCollectionAsync<TEntity> _collection;

    public BaseRepository(LiteDbContextProvider liteDbContext)
    {
        _collection = liteDbContext.Context.GetCollection<TEntity>();
    }

    public async Task<IQueryable<TEntity>> GetAllAsync()
    {
        return (await _collection.FindAllAsync().ConfigureAwait(false)).AsQueryable();
    }

    public async Task<TEntity> GetByIdAsync(Guid entityId)
    {
        return await _collection.FindByIdAsync(new BsonValue(entityId));
    }

    public async Task DeleteAsync(TEntity entity)
    {
        await _collection.DeleteAsync(new BsonValue(entity.Id));
    }

    public async Task UpsertAsync(TEntity entity)
    {
        await _collection.UpsertAsync(entity);
    }
}
