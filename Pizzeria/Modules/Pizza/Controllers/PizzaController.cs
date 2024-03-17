using Microsoft.AspNetCore.Mvc;
using Pizzeria.Modules.Pizza.Builder;
using Pizzeria.Modules.Pizza.Data;
using Pizzeria.Modules.Shared.Controllers;

namespace Pizzeria.Modules.Pizza.Controllers;

public class PizzaController : BaseApiController
{
    private readonly PizzaBuilder _pizzaBuilder;
    private readonly PizzaDirector _pizzaDirector;

    public PizzaController()
    {
        _pizzaBuilder = new();
        _pizzaDirector = new(_pizzaBuilder);
    }

    [HttpGet("salami")]
    public ActionResult<PizzaData> GetSalamiPizza()
    {
        _pizzaDirector.MakeSalamiPizza();
        PizzaData pizzaData = _pizzaBuilder.GetResult();
        return Ok(pizzaData);
    }

    [HttpGet("cheese")]
    public ActionResult<PizzaData> GetCheesePizza()
    {
        _pizzaDirector.MakeCheesePizza();
        PizzaData pizzaData = _pizzaBuilder.GetResult();
        return Ok(pizzaData);
    }

    [HttpGet("hawaiian")]
    public ActionResult<PizzaData> GetHawaiianPizza()
    {
        _pizzaDirector.MakeHawaiianPizza();
        PizzaData pizzaData = _pizzaBuilder.GetResult();
        return Ok(pizzaData);
    }
}
