
using Microsoft.AspNetCore.Mvc;

namespace DevOpsDemo.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var products = new[]
        {
            new { Id = 1, Name = "Laptop", Price = 25000 },
            new { Id = 2, Name = "Mouse", Price = 500 },
            new { Id = 3, Name = "Keyboard", Price = 1200 }
        };

        return Ok(products);
    }
}
