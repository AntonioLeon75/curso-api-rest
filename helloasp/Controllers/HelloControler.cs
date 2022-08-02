using Microsoft.AspNetCore.Mvc;

[Route("[Controller]")]
public class HelloController : Controller
{
    private readonly ISaluteService _svc;

    public HelloController(ISaluteService svc)
    {
        _svc = svc;
    }

    [HttpGet("Salute")]
    public IActionResult SayHello()
    {
        return Ok(new { Data = _svc.GetSalute() });
    }
}
