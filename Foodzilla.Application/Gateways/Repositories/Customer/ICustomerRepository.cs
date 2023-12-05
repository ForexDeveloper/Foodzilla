namespace Foodzilla.Application.Gateways.Repositories.Customer;

using Foodzilla.Domain.Aggregates.Customer;
using Foodzilla.Kernel.Contract.Repositories;

public interface ICustomerRepository : IRepository<Customer, int>
{
    void Attach(Customer customer);
}