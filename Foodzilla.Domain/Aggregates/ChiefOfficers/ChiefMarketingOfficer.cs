﻿using Foodzilla.Domain.Aggregates.TeamLeads;
using Foodzilla.Kernel.Patch;

namespace Foodzilla.Domain.Aggregates.ChiefOfficers;

public sealed class ChiefMarketingOfficer : ChiefUnitIdentity, IPatchValidator
{
    public int ChiefExecutiveOfficerId { get; init; }

    public ChiefExecutiveOfficer? ChiefExecutiveOfficer { get; init; }

    public List<MarketingTeamLead> MarketingTeamLeads { get; init; } = new List<MarketingTeamLead>();

    private ChiefMarketingOfficer(int id, string name, string lastName, string nationalCode, string personalCode, string address, int age, int? daysOfVacation, decimal? height, decimal? weight, bool isFired, Guid uniqueIdentifier, EyeColor? eyeColor, Graduation graduation, Experience experience, DateTimeOffset? modifiedDate, DateTimeOffset birthDate, DateTimeOffset contraDateEnd, DateTimeOffset contraDateStart, string assignedOrganization)
        : base(name, lastName, nationalCode, personalCode, address, age, daysOfVacation, height, weight, isFired, uniqueIdentifier, eyeColor, graduation, experience, modifiedDate, birthDate, contraDateEnd, contraDateStart, assignedOrganization)
    {
        SetIdentity(id);
    }

    private ChiefMarketingOfficer()
    {

    }

    public static ChiefMarketingOfficer Create(int id, string name, string lastName, string nationalCode, string personalCode, string address, int age, int? daysOfVacation, decimal? height, decimal? weight, bool isFired, Guid uniqueIdentifier, EyeColor? eyeColor, Graduation graduation, Experience experience, DateTimeOffset? modifiedDate, DateTimeOffset birthDate, DateTimeOffset contraDateEnd, DateTimeOffset contraDateStart, string assignedOrganization)
    {
        return new ChiefMarketingOfficer(id, name, lastName, nationalCode, personalCode, address, age, daysOfVacation, height, weight, isFired, uniqueIdentifier, eyeColor, graduation, experience, modifiedDate, birthDate, contraDateEnd, contraDateStart, assignedOrganization);
    }

    public void AddLeadMarketing(MarketingTeamLead marketingTeamLead)
    {
        MarketingTeamLeads.Add(marketingTeamLead);
    }

    public bool OnPatchCompleted()
    {
        return true;
    }
}