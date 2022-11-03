using net_advanced_course.DAL.Entities;

namespace net_advanced_course.BLL.Services.Carts
{
    public interface ICartService
    {
        Task<Cart> GetByIdAsync(Guid cartId);

        Task<IEnumerable<Cart>> GetAllAsync();

        Task UpsertAsync(Cart cart);

        Task DeleteAsync(Cart cart);
    }
}
