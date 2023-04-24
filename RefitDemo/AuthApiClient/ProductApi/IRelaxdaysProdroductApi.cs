using Refit;
using RefitDemo.AuthApiClient.ProductApi.Dtos;

namespace RefitDemo.AuthApiClient.ProductApi;

public interface IRelaxdaysProdroductApi
{
    [Get("/content/v1/api/products/{id}")]
    public Task<IApiResponse<List<ProductGetResponse>>> GetProducts([AliasAs("id")]string productId, ProductGetRequest productGetRequest, CancellationToken cancellationToken);
}