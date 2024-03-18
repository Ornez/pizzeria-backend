using Pizzeria.Modules.Transport.Carriers;

namespace Pizzeria.Modules.Transport.Companies;

//Tydzień 2, Wzorzec Factory Method 1
// Wzorzec kreacyjny, klasa zawiera metodę, która używa metody wytwórczej (implementacja w klasach dziedziczących)
// W zależności od klasy dziedziczącej spodziewamy się utworzenia innego przewoźnika.
public abstract class TransportCompany
{
    protected abstract ICarrier CreateCarrier();

    public float GetPrice()
    {
        ICarrier carrier = CreateCarrier();
        // carrier...
        return carrier.GetPrice();
    }
}
