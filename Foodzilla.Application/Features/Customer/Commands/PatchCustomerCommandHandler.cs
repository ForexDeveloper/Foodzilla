namespace Foodzilla.Application.Features.Customer.Commands;

using MediatR;
using Foodzilla.Kernel.Patch;
using Domain.Aggregates.Customer;
using Foodzilla.Application.Gateways.Repositories.Customer;

public sealed class PatchCustomerCommandHandler : IRequestHandler<PatchCustomerCommand, IEnumerable<PatchCustomerResponse>>
{
    private readonly ICustomerRepository _customerRepository;

    public PatchCustomerCommandHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<IEnumerable<PatchCustomerResponse>> Handle(PatchCustomerCommand command, CancellationToken cancellationToken)
    {
        var patchOperator = PatchDocument<Customer>.Create(command.PatchEntities);

        var ids = patchOperator.EntityIds.ConvertAll(int.Parse);

        var customers = await _customerRepository.GetAllAsync(ids);

        var objects = new List<object>();

        foreach (var customer in customers)
        {
            var result = patchOperator.ApplyOneToOne(customer, null, null);

            if (!result)
            {
                objects.AddRange(patchOperator.InvalidResults);
            }
        }

        await _customerRepository.UnitOfWork.SaveChangesAsync();

        var a = 2;

        return customers.Select(p => new PatchCustomerResponse()
        {
            Id = p.Id,
            Family = p.Family,
            NationalCode = p.NationalCode,
            Boolean = p.Boolean,
            BooleanNullable = p.BooleanNullable,
            CustomerRank = Enum.GetName(p.CustomerRank),
            CustomerRankNullable = p.CustomerRankNullable.HasValue ? Enum.GetName(p.CustomerRankNullable.Value) : null,
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
        });
    }
}