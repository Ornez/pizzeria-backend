using Pizzeria.Modules.Transport.Data;

namespace Pizzeria.Modules.Transport.Services;

public interface ITransportService
{
    float GetPriceForTransportCompany(TransportCompanies company);
}
