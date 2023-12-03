namespace Foodzilla.Application.Features.Customer.Queries;

using MediatR;
using Foodzilla.Domain.Enums;

public sealed class GetCustomerListQuery : IRequest<List<GetCustomerListResponse>>
{
}

public sealed class GetCustomerListResponse
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Family { get; set; } = null!;

    public string NationalCode { get; set; } = null!;

    public string String { get; set; }

    public string? StringNullable { get; set; }

    public CustomerRank CustomerRank { get; set; }

    public CustomerRank? CustomerRankNullable { get; set; }

    public bool Boolean { get; set; }

    public bool? BooleanNullable { get; set; }

    public int Int { get; set; }

    public int? IntNullable { get; set; }

    public double Double { get; set; }

    public double? DoubleNullable { get; set; }

    public decimal Decimal { get; set; }

    public decimal? DecimalNullable { get; set; }

    public long Long { get; set; }

    public long? LongNullable { get; set; }

    public Guid Guid { get; set; }

    public Guid? GuidNullable { get; set; }

    public DateTimeOffset DateTime { get; set; }

    public DateTimeOffset? DateTimeNullable { get; set; }
}