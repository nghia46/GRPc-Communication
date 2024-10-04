using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class BaseController : Controller
{
    [HttpGet]
    public virtual IActionResult Get()
    {
        return Ok("This is Service B");
    }
}