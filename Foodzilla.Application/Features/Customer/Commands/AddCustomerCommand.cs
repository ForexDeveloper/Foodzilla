namespace Foodzilla.Application.Features.Customer.Commands;

using MediatR;

public sealed class AddCustomerCommand : IRequest<long>
{
    public string Name { get; set; }

    public string Family { get; set; }

    public string NationalCode { get; set; }
}