using CartingService.API.ApiModels;
using CartingService.BLL.Services.Carts;
using System.Collections.Generic;

namespace CartingService.API.Controllers.v2;

[ApiController]
[ApiVersion("2.0")]
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

    [HttpGet]
    [MapToApiVersion("2.0")]
    public async Task<IActionResult> GetAllAsync()
    {
        var carts = await _cartService.GetAllAsync();

        return Ok(_mapper.Map<IEnumerable<CartDto>>(carts));
    }
}
