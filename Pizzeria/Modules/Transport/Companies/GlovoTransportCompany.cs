using Pizzeria.Modules.Transport.Carriers;

namespace Pizzeria.Modules.Transport.Companies;

public class GlovoTransportCompany : TransportCompany
{
    protected override ICarrier CreateCarrier()
    {
        return new GlovoCarrier();
    }
}
