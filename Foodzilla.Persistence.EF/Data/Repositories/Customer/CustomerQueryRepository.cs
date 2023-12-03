namespace Foodzilla.Persistence.EF.Data.Repositories.Customer;

using Domain.Aggregates.Customer;
using Microsoft.EntityFrameworkCore;
using Foodzilla.Kernel.Persistence.EF.Repositories;
using Foodzilla.Application.Features.Customer.Queries;
using Foodzilla.Application.Gateways.Repositories.Customer;

public sealed class CustomerQueryRepository : QueryRepository<ApplicationQueryDbContext>, ICustomerQueryRepository
{
    public CustomerQueryRepository(ApplicationQueryDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<List<GetCustomerListResponse>> GetCustomerListAsync(int[] ids)
    {
        return await DbContext.Customers.Select(p => new GetCustomerListResponse
        {
            Id = p.Id,
            Family = p.Family,
            NationalCode = p.NationalCode,
            Boolean = p.Boolean,
            BooleanNullable = p.BooleanNullable,
            CustomerRank = p.CustomerRank,
            CustomerRankNullable = p.CustomerRankNullable,
            DateTime = p.DateTime,
            DateTimeNullable = p.DateTimeNullable,
            Double = p.Double,
            DoubleNullable = p.DoubleNullable,
            Int = p.Int,
            IntNullable = p.IntNullable,
            Long = p.Long,
            LongNullable = p.LongNullable,
            Name = p.Name,
            String = p.String,
            StringNullable = p.StringNullable,
            Guid = p.Guid,
            GuidNullable = p.GuidNullable,
            Decimal = p.Decimal,
            DecimalNullable = p.DecimalNullable,
        }).ToListAsync();
    }

    public async Task<Customer> GetCustomerAsync(int id)
    {
        return await DbContext.Customers.FirstOrDefaultAsync(p => p.Id == id);
    }
}