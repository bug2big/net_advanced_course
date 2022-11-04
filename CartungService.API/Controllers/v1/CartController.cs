using CartingService.API.ApiModels;
using CartingService.BLL.Services.Carts;
using CartingService.DAL.Entities;

namespace CartingService.API.Controllers.v1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/{v:apiVersion}/cart")]
public class CartController : ControllerBase
{
    private readonly ICartService _cartService;
    private readonly IMapper _mapper;

    public CartController(
        ICartService cartService,
        IMapper mapper)
    {
        _cartService = cartService;
        _mapper = mapper;
    }

    [HttpGet("{id}")]
    [MapToApiVersion("1.0")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        return Ok(await _cartService.GetByIdAsync(id));
    }

    [HttpPatch]
    [HttpPost]
    [MapToApiVersion("1.0")]
    public async Task<IActionResult> UpsertAsync(CartDto cartDto)
    {
        var cart = _mapper.Map<Cart>(cartDto);

        await _cartService.UpsertAsync(cart);
        return Ok();
    }

    [HttpDelete("{id}")]
    [MapToApiVersion("1.0")]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        var cart = await _cartService.GetByIdAsync(id);

        if (cart == null)
        {
            return NotFound();
        }

        await _cartService.DeleteAsync(cart);

        return Ok();
    }
}
