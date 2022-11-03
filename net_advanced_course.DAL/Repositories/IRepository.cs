namespace net_advanced_course.DAL.Repositories
{
    public interface IRepository<TEntity>
    {
        Task<IQueryable<TEntity>> GetAllAsync();

        Task<TEntity> GetByIdAsync(Guid entityId);

        Task DeleteAsync(TEntity entity);

        Task UpsertAsync(TEntity entity);
    }
}
