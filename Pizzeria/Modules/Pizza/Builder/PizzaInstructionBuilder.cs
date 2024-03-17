using Pizzeria.Modules.Pizza.Data;

namespace Pizzeria.Modules.Pizza.Builder;

public class PizzaInstructionBuilder : IPizzaBuilder
{
    private PizzaInstruction _pizzaInstruction;

    public PizzaInstructionBuilder()
    {
        _pizzaInstruction = new PizzaInstruction();
    }

    public void SetName(string name)
    {
        _pizzaInstruction.Name = name;
    }

    public void SetMozarella()
    {
        _pizzaInstruction.Order.Add("Mozarella");
    }

    public void SetParmezan()
    {
        _pizzaInstruction.Order.Add("Parmezan");
    }

    public void SetPineapple()
    {
        _pizzaInstruction.Order.Add("Pineapple");
    }

    public void SetSalami()
    {
        _pizzaInstruction.Order.Add("Salami");
    }

    public PizzaInstruction GetResult()
    {
        PizzaInstruction result = _pizzaInstruction;
        Reset();
        return result;
    }

    private void Reset()
    {
        _pizzaInstruction = new PizzaInstruction();
    }
}
