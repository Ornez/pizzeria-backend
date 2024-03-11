namespace Pizzeria.src.Modules.Pizza.Builder;

using Pizzeria.src.Modules.Pizza.Data;

public class PizzaBuilder : IPizzaBuilder
{
    private PizzaData _pizza;

    public PizzaBuilder()
    {
        _pizza = new PizzaData();
    }

    public void SetName(string name)
    {
        _pizza.Name = name;
    }

    public void SetMozarella()
    {
        _pizza.Mozalerra = true;
    }

    public void SetParmezan()
    {
        _pizza.Parmezan = true;
    }

    public void SetPineapple()
    {
        _pizza.Pineapple = true;
    }

    public void SetSalami()
    {
        _pizza.Salami = true;
    }

    public PizzaData GetResult()
    {
        PizzaData result = _pizza;
        Reset();
        return result;
    }

    private void Reset()
    {
        _pizza = new PizzaData();
    }
}
