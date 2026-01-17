using PizzaShop.Models;

namespace PizzaShop.Services;

public static class PizzaService 
{
    static List<Pizza> Pizzas {get; }
    static int nextId = 3;
    static PizzaService() 
    {
        Pizzas = new List<Pizza>
        {
            new Pizza {}
        };
    }
    
}