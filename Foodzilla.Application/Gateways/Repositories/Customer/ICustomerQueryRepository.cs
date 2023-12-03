namespace Foodzilla.Application.Gateways.Repositories.Customer;

using Domain.Aggregates.Customer;
using Foodzilla.Kernel.Contract.Repositories;
using Foodzilla.Application.Features.Customer.Queries;

public interface ICustomerQueryRepository : IQueryRepository
{
    Task<List<GetCustomerListResponse>> GetCustomerListAsync(int[] ids);

    Task<Customer> GetCustomerAsync(int id);
}