using Microsoft.EntityFrameworkCore;

using InventorySystem.Data;
using InventorySystem.Models;

namespace InventorySystem.Services;

public interface IPizzaService
{
    Task<List<Pizza>> GetAll();
    Task Add(Pizza pizza);
}

public class PizzaService: IPizzaService
{
    private readonly AppDbContext _context;

    public PizzaService(AppDbContext context) => _context = context;

    public async Task<List<Pizza>> GetAll() => await _context.Pizzas.ToListAsync();

    public async Task Add(Pizza pizza)
    {
        _context.Pizzas.Add(pizza);
        await _context.SaveChangesAsync();
    }
}