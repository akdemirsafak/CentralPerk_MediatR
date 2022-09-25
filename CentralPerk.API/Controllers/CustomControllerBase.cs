using CentralPerk.API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CentralPerk.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomControllerBase : ControllerBase
{
    [NonAction]
    public IActionResult CreateActionResult<T>(ResponseDto<T> response)
    {
        if (response.StatusCode == 204)
            return new ObjectResult(null) { StatusCode = response.StatusCode };

        return new ObjectResult(response) { StatusCode = response.StatusCode };
    }
}