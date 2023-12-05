using Foodzilla.Domain.Aggregates.ChiefOfficers;

namespace Foodzilla.Persistence.EF.Data.Repositories.Customer;

using Foodzilla.Domain.Aggregates.Customer;
using Foodzilla.Kernel.Persistence.EF.Repositories;
using Foodzilla.Application.Gateways.Repositories.Customer;

public sealed class CustomerRepository : Repository<ApplicationDbContext, Customer, int>, ICustomerRepository
{
    public CustomerRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public void Attach(Customer customer)
    {
        DbContext.Customers.Attach(customer);
        DbContext.Entry(customer).Property("Name").IsModified = true;
    }
}