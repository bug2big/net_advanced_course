using AutoMapper;
using CartingService.API.ApiModels;
using CartingService.DAL.Entities;

namespace CartungService.BLL.Common;

public class MapperConfiguration : Profile
{
    public MapperConfiguration()
    {
        CartMapping();
    }

    private void CartMapping()
    {
        CreateMap<Cart, CartDto>()
            .ReverseMap();
    }
}

