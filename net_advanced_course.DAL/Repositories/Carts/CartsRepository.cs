using net_advanced_course.DAL.Entities;

namespace net_advanced_course.DAL.Repositories.Carts
{
    public class CartRepository : BaseRepository<Cart>, ICartRepository
    {
        public CartRepository(LiteDbContextProvider liteDbContextProvider)
            : base(liteDbContextProvider)
        {
        }
    }
}
