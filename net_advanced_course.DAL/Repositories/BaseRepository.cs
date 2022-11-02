using LiteDB;
using Microsoft.Extensions.Options;
using net_advanced_course.DAL.Entities;
using net_advanced_course.DAL.Settings;

namespace net_advanced_course.DAL.Repositories
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity>
        where TEntity : BaseEntity
    {
        protected readonly LiteDatabase _context = null!;
        protected readonly ILiteCollection<TEntity> _collection;

        public BaseRepository(IOptions<LiteDbSettings> liteDbSettingOptions)
        {
            try
            {
                var db = new LiteDatabase(liteDbSettingOptions.Value.DatabasePath);
                if (db != null)
                    _context = db;

                _collection = _context.GetCollection<TEntity>();

            }
            catch (Exception ex)
            {
                throw new Exception("Can find or create LiteDb database.", ex);
            }
        }

        public IQueryable<TEntity> GetAll()
        {
            return _collection.FindAll().AsQueryable();
        }

        public TEntity GetById(Guid entityId)
        {
            return _collection.FindById(new BsonValue(entityId));
        }

        public void Delete(TEntity entity)
        {
            _collection.Delete(new BsonValue(entity.Id));
        }

        public void Upsert(TEntity entity)
        {
            _collection.Upsert(entity);
        }
    }
}
