using net_advanced_course.DAL.Entities;
using net_advanced_course.DAL.Repositories.Carts;

namespace net_advanced_course.BLL.Services.Carts
{
    public class CartingService : ICartingService
    {
        private readonly ICartRepository _cartRepository;

        public CartingService(
            ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public Cart GetById(Guid cartId)
        {
            return _cartRepository.GetById(cartId);
        }

        public IEnumerable<Cart> GetAll()
        {
            return _cartRepository.GetAll();
        }

        public void Upsert(Cart cart)
        {
            _cartRepository.Upsert(cart);
        }

        public void Delete(Cart cart)
        {
            _cartRepository.Delete(cart);
        }
    }
}