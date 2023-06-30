using Microsoft.AspNetCore.Mvc;

namespace SingleApiProject.Controllers;

[ApiController]
[Route("[controller]")]
public class SingleApi : ControllerBase
{
   

    private readonly ILogger<SingleApi> _logger;

    public SingleApi(ILogger<SingleApi> logger)
    {
        _logger = logger;
    }
    [HttpGet("profile")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult GetProfile()
    {
        try
        {
            _logger.LogInformation("Fetching Profile");
            var response = new Profile()
            {
                Name= "Abu",
                Age = 10,
                Gender = "Male",
                Place = "Kochi"
            };

            _logger.LogInformation("Profile fetched successfully");
            return Ok(response);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error While Fetching Profile");
            return Problem("Error While Fetching Profile");
        }
    }
}