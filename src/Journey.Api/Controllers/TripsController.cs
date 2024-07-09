using Journey.Communication.Requests;
using Microsoft.AspNetCore.Mvc;


namespace Journey.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TripsController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterTripJson request)
    {
        return Created();


    }
}

