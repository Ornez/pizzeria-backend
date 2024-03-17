using Microsoft.AspNetCore.Mvc;
using Pizzeria.Modules.Pizza.Builder;
using Pizzeria.Modules.Pizza.Data;
using Pizzeria.Modules.Shared.Controllers;

namespace Pizzeria.Modules.Pizza.Controllers;

public class PizzaInstructionController : BaseApiController
{
    private readonly PizzaInstructionBuilder _pizzaInstructionBuilder;
    private readonly PizzaDirector _pizzaDirector;

    public PizzaInstructionController()
    {
        _pizzaInstructionBuilder = new();
        _pizzaDirector = new(_pizzaInstructionBuilder);
    }

    [HttpGet("salami")]
    public ActionResult<PizzaInstruction> GetSalamiPizzaInstruction()
    {
        _pizzaDirector.MakeSalamiPizza();
        PizzaInstruction pizzaInstruction = _pizzaInstructionBuilder.GetResult();
        return Ok(pizzaInstruction);
    }

    [HttpGet("cheese")]
    public ActionResult<PizzaInstruction> GetCheesePizzaInstruction()
    {
        _pizzaDirector.MakeCheesePizza();
        PizzaInstruction pizzaInstruction = _pizzaInstructionBuilder.GetResult();
        return Ok(pizzaInstruction);
    }

    [HttpGet("hawaiian")]
    public ActionResult<PizzaInstruction> GetHawaiianPizzaInstruction()
    {
        _pizzaDirector.MakeHawaiianPizza();
        PizzaInstruction pizzaInstruction = _pizzaInstructionBuilder.GetResult();
        return Ok(pizzaInstruction);
    }
}
