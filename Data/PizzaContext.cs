using Microsoft.EntityFrameworkCore;
using InventorySystem.Models;

namespace InventorySystem.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Pizza> Pizzas => Set<Pizza>();
}