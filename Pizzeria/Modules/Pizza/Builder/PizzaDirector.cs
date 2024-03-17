namespace Pizzeria.Modules.Pizza.Builder;

//Tydzień 2, Wzorzec Builder 1
// Wzorzec kreacyjny, wariant wykorzystujący jednego dyrektora, bez płynnego interfejsu (zwracania typu klasy w metodach)
// Istnieje interfejs budowniczego, oraz dwóch budowniczych konkretnych (PizzaBuilder, PizzaInstructionBuilder).
// Dyrektor opisuje algorytm, konkretny budowniczy opisuje konkretne kroki.
// Poprzez wstrzyknięcie odpowiedniego budowniczego w klasę dyrektora, możemy oczekiwać innego rezultatu, bez zmiany algorytmu tworzącego obiekt.
public class PizzaDirector
{
    private IPizzaBuilder _builder;

    public PizzaDirector(IPizzaBuilder builder)
    {
        _builder = builder;
    }

    public void ChangeBuilder(IPizzaBuilder builder)
    {
        _builder = builder;
    }

    public void MakeCheesePizza()
    {
        _builder.SetName("Cheese pizza");
        _builder.SetMozarella();
        _builder.SetParmezan();
    }

    public void MakeSalamiPizza()
    {
        _builder.SetName("Salami pizza");
        _builder.SetSalami();
    }

    public void MakeHawaiianPizza()
    {
        _builder.SetName("Hawaiian pizza");
        _builder.SetPineapple();
    }
}
//Koniec, Tydzień 2, Wzorzec Builder 1.