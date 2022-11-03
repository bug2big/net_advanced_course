using net_advanced_course.DAL.Entities;
using net_advanced_course.DAL.Repositories.Carts;

namespace net_advanced_course.BLL.Services.Carts
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;

        public CartService(
            ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public async Task<Cart> GetByIdAsync(Guid cartId)
        {
            return await _cartRepository.GetByIdAsync(cartId);
        }

        public async Task<IEnumerable<Cart>> GetAllAsync()
        {
            return await _cartRepository.GetAllAsync();
        }

        public async Task UpsertAsync(Cart cart)
        {
            await _cartRepository.UpsertAsync(cart);
        }

        public async Task DeleteAsync(Cart cart)
        {
            await _cartRepository.DeleteAsync(cart);
        }
    }
}