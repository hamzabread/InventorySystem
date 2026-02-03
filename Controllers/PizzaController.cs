using InventorySystem.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using InventorySystem.Services;

[ApiController]
[Route("api/[controller]")]

public class PizzaController : ControllerBase
{

    private readonly IPizzaService _service;

    public PizzaController(IPizzaService service) => _service = service;

    [HttpGet]
    public async Task<ActionResult<List<Pizza>>> Get() => Ok(await _service.GetAll());

    [HttpPost]
    public async Task<IActionResult> Add(Pizza pizza)
    {
        await _service.Add(pizza);
        return Ok();
    } 
}