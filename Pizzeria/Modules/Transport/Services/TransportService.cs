using Pizzeria.Modules.Transport.Companies;
using Pizzeria.Modules.Transport.Data;

namespace Pizzeria.Modules.Transport.Services;

public class TransportService : ITransportService
{
    public float GetPriceForTransportCompany(TransportCompanies company)
    {
        TransportCompany transportCompany;
        switch (company)
        {
            case TransportCompanies.uber:
                transportCompany = new UberTransportCompany();
                break;
            case TransportCompanies.glovo:
                transportCompany = new GlovoTransportCompany();
                break;
            default: 
                throw new ArgumentException($"Argument: {company} not implemented.");
        }
        return transportCompany.GetPrice();
    }
}
