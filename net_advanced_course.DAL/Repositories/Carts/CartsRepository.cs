using Microsoft.Extensions.Options;
using net_advanced_course.DAL.Settings;
using net_advanced_course.DAL.Entities;

namespace net_advanced_course.DAL.Repositories.Carts
{
    public class CartRepository : BaseRepository<Cart>, ICartRepository
    {
        public CartRepository(IOptions<LiteDbSettings> liteDbSettingOptions)
            : base(liteDbSettingOptions)
        {
        }
    }
}
