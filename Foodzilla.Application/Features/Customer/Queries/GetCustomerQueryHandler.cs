namespace Foodzilla.Application.Features.Customer.Queries;

using MediatR;
using Domain.Aggregates.Customer;
using Foodzilla.Application.Gateways.Repositories.Customer;

public sealed class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, GetCustomerResponse>
{
    private readonly ICustomerRepository _customerRepository;
    private readonly ICustomerQueryRepository _queryRepository;

    public GetCustomerQueryHandler(ICustomerRepository repository, ICustomerQueryRepository queryRepository)
    {
        _customerRepository = repository;
        _queryRepository = queryRepository;
    }

    public async Task<GetCustomerResponse> Handle(GetCustomerQuery query, CancellationToken cancellationToken)
    {
        var customer = await _queryRepository.GetCustomerAsync(query.Id);

        if (customer == null)
        {
            return null;
        }

        var attachedCustomer = new Customer();

        attachedCustomer.SetName();

        _customerRepository.Attach(attachedCustomer);

        await _customerRepository.UnitOfWork.SaveChangesAsync();

        return new GetCustomerResponse(customer.Id, customer.Name, customer.Family, customer.NationalCode);
    }
}