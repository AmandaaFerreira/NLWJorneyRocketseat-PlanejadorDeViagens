using Journey.Application.UseCases.GetAll;
using Journey.Application.UseCases.Trips.Register;
using Journey.Communication.Requests;
using Journey.Communication.Responses;
using Microsoft.AspNetCore.Mvc;


namespace Journey.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TripsController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseShortTripJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(String), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestRegisterTripJson request)
    {
        var useCase = new RegisterTripUseCase();

        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseTripsJson), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllTripsUseCase();

        var result = useCase.Execute();

        return Ok(result);

    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTripJson),StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string),StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] Guid id)
    {
        var useCase = new GetAllTripsUseCase();

        var response = useCase.Execute();

        return Ok(response);
    }
}