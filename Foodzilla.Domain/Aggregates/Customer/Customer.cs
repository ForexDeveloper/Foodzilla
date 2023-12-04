using Foodzilla.Domain.Enums;
using Foodzilla.Kernel.Domain;
using Foodzilla.Kernel.Patch;
using Microsoft.EntityFrameworkCore;

namespace Foodzilla.Domain.Aggregates.Customer;

public sealed class Customer : Entity<int>, IAggregateRoot, IPatchValidator
{

    private readonly List<Order> _orders = new();

    public string Name { get; private set; } = null!;

    public string Family { get; private set; } = null!;

    public string NationalCode { get; private set; } = null!;

    public string String { get; private set; }

    public string? StringNullable { get; private set; }

    public CustomerRank CustomerRank { get; private set; }

    public CustomerRank? CustomerRankNullable { get; private set; }

    public bool Boolean { get; private set; }

    public bool? BooleanNullable { get; private set; }

    public int Int { get; private set; }

    public int? IntNullable { get; private set; }

    public double Double { get; private set; }

    public double? DoubleNullable { get; private set; }

    public decimal Decimal { get; private set; }

    public decimal? DecimalNullable { get; private set; }

    public long Long { get; private set; }

    public long? LongNullable { get; private set; }

    public Guid Guid { get; private set; }

    public Guid? GuidNullable { get; private set; }

    public DateTimeOffset DateTime { get; private set; }

    public DateTimeOffset? DateTimeNullable { get; private set; }


    [BackingField(nameof(_orders))]
    public IReadOnlyCollection<Order> Orders => _orders;

    public Customer()
    {

    }

    private Customer(string name, string family, string nationalCode, string s, string? stringNullable, CustomerRank customerRank, CustomerRank? customerRankNullable, bool boolean, bool? booleanNullable, int i, int? intNullable, double d, double? doubleNullable, decimal @decimal, decimal? decimalNullable, long l, long? longNullable, Guid guid, Guid? guidNullable, DateTimeOffset dateTime, DateTimeOffset? dateTimeNullable)
    {
        Name = name;
        Family = family;
        NationalCode = nationalCode;
        String = s;
        StringNullable = stringNullable;
        CustomerRank = customerRank;
        CustomerRankNullable = customerRankNullable;
        Boolean = boolean;
        BooleanNullable = booleanNullable;
        Int = i;
        IntNullable = intNullable;
        Double = d;
        DoubleNullable = doubleNullable;
        Decimal = @decimal;
        DecimalNullable = decimalNullable;
        Long = l;
        LongNullable = longNullable;
        Guid = guid;
        GuidNullable = guidNullable;
        DateTime = dateTime;
        DateTimeNullable = dateTimeNullable;
    }

    public static Customer Create(string name, string family, string nationalCode, string s, string? stringNullable, CustomerRank customerRank, CustomerRank? customerRankNullable, bool boolean, bool? booleanNullable, int i, int? intNullable, double d, double? doubleNullable, decimal @decimal, decimal? decimalNullable, long l, long? longNullable, Guid guid, Guid? guidNullable, DateTimeOffset dateTime, DateTimeOffset? dateTimeNullable)
    {
        return new Customer(name, family, nationalCode, s, stringNullable, customerRank, customerRankNullable, boolean, booleanNullable, i, intNullable, d, doubleNullable, @decimal, decimalNullable, l, longNullable, guid, guidNullable, dateTime, dateTimeNullable);
    }

    public void SetName()
    {
        SetIdentity(1);
        Name = "Attached";
    }

    public bool OnPatchCompleted()
    {
        return true;
    }
}