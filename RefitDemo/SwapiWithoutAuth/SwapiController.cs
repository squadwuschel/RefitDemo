using Microsoft.AspNetCore.Mvc;

namespace RefitDemo.SwapiWithoutAuth;

[ApiController]
public class SwapiController : ControllerBase
{
    private readonly ISwapi _swapi;

    public SwapiController(ISwapi swapi)
    {
        _swapi = swapi;
    }
    
    [Route("v1/swapi")]
    [HttpGet]
    public async Task<IActionResult> Get(string personId, CancellationToken cancellationToken)
    {
        var response = await _swapi.GetPerson(personId, cancellationToken);

        if (response.IsSuccessStatusCode)
        {
            return Ok(response.Content);
        }

        return StatusCode((int) response.StatusCode);
    }
        
}