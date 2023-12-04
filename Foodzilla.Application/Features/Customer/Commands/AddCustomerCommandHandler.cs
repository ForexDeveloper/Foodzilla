namespace Foodzilla.Application.Features.Customer.Commands;

using MediatR;
using Gateways.Repositories;
using Foodzilla.Domain.Enums;
using Domain.Aggregates.Customer;
using Foodzilla.Application.Gateways.Repositories.Customer;

public sealed class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand, long>
{
    private readonly ICustomerRepository _customerRepository;

    public AddCustomerCommandHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<long> Handle(AddCustomerCommand command, CancellationToken cancellationToken)
    {
        var customer = Customer.Create(
            command.Name,
            command.Family,
            command.NationalCode,
            "String",
            null,
            CustomerRank.Gold,
            null,
            true,
            null,
            10,
            null,
            14.123,
            null,
            12321.12312M,
            null,
            100,
            null,
            Guid.NewGuid(),
            null,
            DateTime.Now,
            null);

        _customerRepository.Add();

        //await _customerRepository.AddAsync(customer);

        await _customerRepository.UnitOfWork.SaveChangesAsync();

        return customer.Id;
    }
}