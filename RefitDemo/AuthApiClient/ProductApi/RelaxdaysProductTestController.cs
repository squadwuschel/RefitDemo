using Microsoft.AspNetCore.Mvc;
using RefitDemo.AuthApiClient.ProductApi.Dtos;

namespace RefitDemo.AuthApiClient.ProductApi;

[ApiController]
public class RelaxdaysProductTestController : ControllerBase
{
    private readonly IRelaxdaysProdroductApi _client;

    public RelaxdaysProductTestController(IRelaxdaysProdroductApi client)
    {
        _client = client;
    }
   
    [Route("v1/authapi-products")]
    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        var request = new ProductGetRequest()
        {
            Attributes = "TitleShop,DescriptionLongMarketplaces,VideoUrlExternal,VideoUrlInternal"
        };
        
        var response = await _client.GetProducts("10010019_0",request, cancellationToken);

        if (response.IsSuccessStatusCode)
        {
            return Ok(response.Content);
        }

         return StatusCode((int) response.StatusCode);
    }
}