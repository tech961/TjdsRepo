using Rs.Application.Common.Models;
using Rs.Application.Features.Products.CommandHandlers.AddProduct;
using Rs.Application.Features.Products.QueryHandlers.GetProducts;

namespace Rs.Api.Controllers;

public class ProductController : BaseController
{
    [HttpGet]
    public async Task<ActionResult<PaginatedList<GetProductsResponse>>> GetProducts([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 20, CancellationToken cancellationToken = default)
    {
        var query = new GetProductsQuery(pageNumber, pageSize);
        var result = await Mediator.Send(query, cancellationToken);
        return result.ToActionResult();
    }

    [HttpPost]
    public async Task<ActionResult<AddProductResponse>> AddProduct([FromBody] AddProductCommand command, CancellationToken cancellationToken)
    {
        var result = await Mediator.Send(command, cancellationToken);
        return result.ToActionResult();
    }
}
