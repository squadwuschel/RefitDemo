using Microsoft.AspNetCore.Mvc;

namespace RefitDemo.KeycloakApiClient;

[ApiController]
public class KeyCloakTestController : Controller
{
    private readonly IContentApi _client;

    public KeyCloakTestController(IContentApi client)
    {
        _client = client;
    }
    
    [Route("v1/keycloak-with-repsonse")]
    [HttpGet]
    public async Task<IActionResult> StartVideoUploadWithResponse()
    {
       var result = await _client.StartVideoUploadWithResponse();

       if (result.IsSuccessStatusCode)
       {
           return Ok();   
       }

       return StatusCode((int) result.StatusCode);
    }
    
    [Route("v1/keycloak-without-response")]
    [HttpGet]
    public async Task<IActionResult> StartVideoUploadWithoutResponse()
    {
        await _client.StartVideoUploadWithoutResponse();
        return Ok();   
    }
}