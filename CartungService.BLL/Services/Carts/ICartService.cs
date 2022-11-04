using CartingService.DAL.Entities;

namespace CartingService.BLL.Services.Carts;

public interface ICartService
{
    Task<Cart> GetByIdAsync(Guid cartId);

    Task<IEnumerable<Cart>> GetAllAsync();

    Task UpsertAsync(Cart cart);

    Task DeleteAsync(Cart cart);
}
