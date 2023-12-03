namespace Foodzilla.Application.Features.Customer.Queries;

using MediatR;

public sealed class GetCustomerQuery : IRequest<GetCustomerResponse>
{
    public int Id { get; set; } = 1;
}

public sealed class GetCustomerResponse
{
    public int Id { get; set; }

    public string Name { get; private set; }

    public string Family { get; private set; }

    public string NationalCode { get; private set; }

    public GetCustomerResponse(int id, string name, string family, string nationalCode)
    {
        Id = id;
        Name = name;
        Family = family;
        NationalCode = nationalCode;
    }
}