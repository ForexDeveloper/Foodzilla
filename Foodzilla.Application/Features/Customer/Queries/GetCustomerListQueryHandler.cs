namespace Foodzilla.Application.Features.Customer.Queries;

using MediatR;
using Foodzilla.Application.Gateways.Repositories.Customer;

public sealed class GetCustomerListQueryHandler : IRequestHandler<GetCustomerListQuery, List<GetCustomerListResponse>>
{
    private readonly ICustomerQueryRepository _queryRepository;
    public GetCustomerListQueryHandler(ICustomerQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<List<GetCustomerListResponse>> Handle(GetCustomerListQuery query, CancellationToken cancellationToken)
    {
        var ids = new[]
        {
            1,2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14
        };

        var customers = await _queryRepository.GetCustomerListAsync(ids);

        return customers;
    }
}