using Pizzeria.Modules.Pizza.Data;

namespace Pizzeria.Modules.Basket.Services;

public class BasketService : IBasketService
{
    public List<PizzaData> PizzaDatas { get; set; } = new();

    public void AddPizza(PizzaData pizza)
    {
        PizzaDatas.Add(pizza);
    }

    public void RemovePizza(PizzaData pizza)
    {
        PizzaDatas.Remove(pizza);
    }
}
