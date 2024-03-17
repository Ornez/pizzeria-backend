using Pizzeria.Modules.Shared.Clones;

namespace Pizzeria.Modules.Pizza.Data;

//Tydzień 2, Wzorzec Prototyp 1
// Wzorzec kreacyjny, tworzy kopię obiektu, może rozwiązywać problem z kopiowaniem referencji bądź zależności rekursywnych
public class PizzaData : ICloneable<PizzaData>
{
    public string Name { get; set; } = "";
    public bool Mozalerra { get; set; }
    public bool Parmezan { get; set; }
    public bool Pineapple { get; set; }
    public bool Salami { get; set; }

    public PizzaData Clone()
    {
        return new PizzaData
        {
            Name = this.Name,
            Mozalerra = this.Mozalerra,
            Parmezan = this.Parmezan,
            Pineapple = this.Pineapple,
            Salami = this.Salami
        };
    }
}
