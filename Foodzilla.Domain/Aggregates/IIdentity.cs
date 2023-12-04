namespace Foodzilla.Domain.Aggregates;

public interface IIdentity
{
    public string Name { get; init; }

    public string LastName { get; init; }

    public string NationalCode { get; init; }

    public string PersonalCode { get; init; }

    public string Address { get; init; }

    public int Age { get; init; }

    public int? DaysOfVacation { get; init; }

    public decimal? Height { get; init; }

    public decimal? Weight { get; init; }

    public bool IsFired { get; init; }

    public Guid UniqueIdentifier { get; init; }

    public EyeColor? EyeColor { get; init; }

    public Graduation Graduation { get; init; }

    public Experience Experience { get; init; }

    public DateTimeOffset? ModifiedDate { get; init; }

    public DateTimeOffset BirthDate { get; init; }

    public DateTimeOffset ContractDateEnd { get; init; }

    public DateTimeOffset ContractDateStart { get; init; }
}