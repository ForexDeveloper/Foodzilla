namespace Foodzilla.Application.Features.Customer.Commands;

using System.Dynamic;
using MediatR;

public sealed class PatchCustomerCommand : IRequest<IEnumerable<PatchCustomerResponse>>
{
    public List<ExpandoObject> PatchEntities { get; set; }
}

public sealed class PatchCustomerResponse
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Family { get; set; } = null!;

    public string NationalCode { get; set; } = null!;

    public string String { get; set; }

    public string? StringNullable { get; set; }

    public string CustomerRank { get; set; }

    public string? CustomerRankNullable { get; set; }

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