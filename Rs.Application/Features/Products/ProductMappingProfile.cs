using Rs.Domain.Aggregates.PetShop;

namespace Rs.Application.Features.Products;

public class ProductMappingProfile : Profile
{
    public ProductMappingProfile()
    {
        CreateMap<Product, AddProductResponse>();
        CreateMap<Product, GetProductsResponse>();
    }
}
