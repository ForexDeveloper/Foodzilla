using MediatR;
using Grpc.Core;
using Foodzilla.Presentation.Protos;
using Foodzilla.Application.Features.Customer;
using Foodzilla.Application.Features.Customer.Queries;

namespace Foodzilla.Presentation.GrpcServices;

public sealed class CustomerService : CustomerRpcService.CustomerRpcServiceBase
{
    private readonly IMediator _mediator;

    public CustomerService(IMediator mediator)
    {
        _mediator = mediator;
    }

    public override async Task<GetCustomerRpcResponse> GetCustomerRpc(GetCustomerRpcQuery request, ServerCallContext context)
    {
        var query = new GetCustomerQuery()
        {
            Id = request.Id
        };

        var response = await _mediator.Send(query);

        return new GetCustomerRpcResponse()
        {
            Name = response.Name,
            Family = response.Family,
            NationalCode = response.NationalCode,
        };
    }
}