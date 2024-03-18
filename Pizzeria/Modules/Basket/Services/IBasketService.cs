using Pizzeria.Modules.Pizza.Data;

namespace Pizzeria.Modules.Basket.Services;

public interface IBasketService
{
    List<PizzaData> PizzaDatas { get; set; }
    void AddPizza(PizzaData pizza);
    void RemovePizza(PizzaData pizza);
}
