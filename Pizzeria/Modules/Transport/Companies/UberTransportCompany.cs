using Pizzeria.Modules.Transport.Carriers;

namespace Pizzeria.Modules.Transport.Companies;

public class UberTransportCompany : TransportCompany
{
    protected override ICarrier CreateCarrier()
    {
        return new UberCarrier();
    }
}
