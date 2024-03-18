using Microsoft.AspNetCore.Mvc;
using Pizzeria.Modules.Shared.Controllers;
using Pizzeria.Modules.Transport.Data;
using Pizzeria.Modules.Transport.Services;

namespace Pizzeria.Modules.Transport.Controllers;

public class TransportController : BaseApiController
{
    private readonly ITransportService _transportService;

    public TransportController(ITransportService transportService)
    {
        _transportService = transportService;
    }

    [HttpGet("uber")]
    public ActionResult<float> GetUberPrice()
    {
        float price = _transportService.GetPriceForTransportCompany(TransportCompanies.uber);
        return Ok(price);
    }

    [HttpGet("glovo")]
    public ActionResult<float> GetGlovoPrice()
    {
        float price = _transportService.GetPriceForTransportCompany(TransportCompanies.glovo);
        return Ok(price);
    }
}
