using CartingService.DAL.Entities;

namespace CartingService.DAL.Repositories.Carts;

public class CartRepository : BaseRepository<Cart>, ICartRepository
{
    public CartRepository(LiteDbContextProvider liteDbContextProvider)
        : base(liteDbContextProvider)
    {
    }
}
