using Microsoft.AspNetCore.Mvc;
using Pizzeria.Modules.Basket.Services;
using Pizzeria.Modules.Pizza.Builder;
using Pizzeria.Modules.Pizza.Data;
using Pizzeria.Modules.Shared.Controllers;
using Pizzeria.Modules.Shared.Loggers;

namespace Pizzeria.Modules.Pizza.Controllers;

public class PizzaController : BaseApiController
{
    private readonly PizzaBuilder _pizzaBuilder;
    private readonly PizzaDirector _pizzaDirector;
    private readonly IBasketService _basketService;
    private readonly SimpleLogger _logger;

    public PizzaController(IBasketService basketService)
    {
        _pizzaBuilder = new();
        _pizzaDirector = new(_pizzaBuilder);
        _basketService = basketService;
        _logger = SimpleLogger.GetInstance();
    }

    [HttpGet("salami")]
    public ActionResult<PizzaData> GetSalamiPizza()
    {
        _pizzaDirector.MakeSalamiPizza();
        PizzaData pizzaData = _pizzaBuilder.GetResult();
        _basketService.AddPizza(pizzaData);
        _logger.Log("Salami pizza");
        return Ok(pizzaData);
    }

    [HttpGet("cheese")]
    public ActionResult<PizzaData> GetCheesePizza()
    {
        _pizzaDirector.MakeCheesePizza();
        PizzaData pizzaData = _pizzaBuilder.GetResult();
        _basketService.AddPizza(pizzaData);
        return Ok(pizzaData);
    }

    [HttpGet("hawaiian")]
    public ActionResult<PizzaData> GetHawaiianPizza()
    {
        _pizzaDirector.MakeHawaiianPizza();
        PizzaData pizzaData = _pizzaBuilder.GetResult();
        _basketService.AddPizza(pizzaData);
        return Ok(pizzaData);
    }

    [HttpGet("basket")]
    public ActionResult<List<PizzaData>> GetBasket()
    {
        return Ok(_basketService.PizzaDatas);
    }
}
