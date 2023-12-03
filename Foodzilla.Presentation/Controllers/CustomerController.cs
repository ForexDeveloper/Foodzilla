using Foodzilla.Application.Features.Customer.Commands;
using Foodzilla.Application.Features.Customer.Queries;
using Foodzilla.Kernel.Commons.Api;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Foodzilla.Presentation.Controllers;

//[Authorize]
[AllowAnonymous]
[ApiVersion("1.0")]
public sealed class CustomerController : ApiControllerBase
{

    [HttpGet]
    public async Task<ActionResult> GetCustomer([FromQuery] GetCustomerQuery query)
    {
        var customer = await Mediator.Send(query);
        return Ok(customer);
    }

    [HttpGet]
    public async Task<ActionResult> GetCustomerList([FromQuery] GetCustomerListQuery query)
    {
        var customers = await Mediator.Send(query);
        return Ok(customers);
    }

    [HttpPost]
    public async Task<ActionResult> AddCustomer([FromBody] AddCustomerCommand command)
    {

        var customer = await Mediator.Send(command);
        return Ok(customer);
    }


    [HttpPatch]
    public async Task<ActionResult> PatchCustomer([FromBody] PatchCustomerCommand command)
    {
        var customers = await Mediator.Send(command);
        return Ok(customers);
    }
}