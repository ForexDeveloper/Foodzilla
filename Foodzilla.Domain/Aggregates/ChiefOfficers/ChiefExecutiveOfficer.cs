﻿using Foodzilla.Kernel.Patch;

namespace Foodzilla.Domain.Aggregates.ChiefOfficers;

public sealed class ChiefExecutiveOfficer : ChiefUnitIdentity, IPatchValidator
{
    public ChiefProductOfficer? ChiefProductOfficer { get; private set; }

    public ChiefTechnicalOfficer? ChiefTechnicalOfficer { get; private set; }

    public ChiefMarketingOfficer? ChiefMarketingOfficer { get; private set; }

    private ChiefExecutiveOfficer(int id, string name, string lastName, string nationalCode, string personalCode, string address, int age, int? daysOfVacation, decimal? height, decimal? weight, bool isFired, Guid uniqueIdentifier, EyeColor? eyeColor, Graduation graduation, Experience experience, DateTimeOffset? modifiedDate, DateTimeOffset birthDate, DateTimeOffset contraDateEnd, DateTimeOffset contraDateStart, string assignedOrganization)
        : base(name, lastName, nationalCode, personalCode, address, age, daysOfVacation, height, weight, isFired, uniqueIdentifier, eyeColor, graduation, experience, modifiedDate, birthDate, contraDateEnd, contraDateStart, assignedOrganization)
    {
        SetIdentity(id);
    }

    private ChiefExecutiveOfficer()
    {

    }

    public static ChiefExecutiveOfficer Create(int id, string name, string lastName, string nationalCode, string personalCode, string address, int age, int? daysOfVacation, decimal? height, decimal? weight, bool isFired, Guid uniqueIdentifier, EyeColor? eyeColor, Graduation graduation, Experience experience, DateTimeOffset? modifiedDate, DateTimeOffset birthDate, DateTimeOffset contraDateEnd, DateTimeOffset contraDateStart, string assignedOrganization)
    {
        return new ChiefExecutiveOfficer(id, name, lastName, nationalCode, personalCode, address, age, daysOfVacation, height, weight, isFired, uniqueIdentifier, eyeColor, graduation, experience, modifiedDate, birthDate, contraDateEnd, contraDateStart, assignedOrganization);
    }

    public void AddChiefTechnicalOfficer(ChiefTechnicalOfficer chiefTechnicalOfficer)
    {
        ChiefTechnicalOfficer = chiefTechnicalOfficer;
    }

    public void AddChiefProductOfficer(ChiefProductOfficer chiefProductOfficer)
    {
        ChiefProductOfficer = chiefProductOfficer;

    }

    public void AddChiefMarketingOfficer(ChiefMarketingOfficer chiefMarketingOfficer)
    {
        ChiefMarketingOfficer = chiefMarketingOfficer;
    }

    public bool OnPatchCompleted()
    {
        return true;
    }
}