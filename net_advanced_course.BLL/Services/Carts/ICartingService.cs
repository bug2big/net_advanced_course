using net_advanced_course.DAL.Entities;

namespace net_advanced_course.BLL.Services.Carts
{
    public interface ICartingService
    {
        Cart GetById(Guid cartId);

        IEnumerable<Cart> GetAll();

        void Upsert(Cart cart);

        void Delete(Cart cart);
    }
}
