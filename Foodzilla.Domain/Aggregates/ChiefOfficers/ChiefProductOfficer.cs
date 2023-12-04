﻿using Foodzilla.Domain.Aggregates.TeamLeads;
using Foodzilla.Kernel.Patch;

namespace Foodzilla.Domain.Aggregates.ChiefOfficers;

public sealed class ChiefProductOfficer : ChiefUnitIdentity, IPatchValidator
{
    public int ChiefExecutiveOfficerId { get; init; }

    public ChiefExecutiveOfficer? ChiefExecutiveOfficer { get; init; }

    public List<ProductTeamLead> ProductTeamLeads { get; init; } = new List<ProductTeamLead>();

    public List<ScrumMasterTeamLead> ScrumMasterTeamLeads { get; init; } = new List<ScrumMasterTeamLead>();

    private ChiefProductOfficer(int id, string name, string lastName, string nationalCode, string personalCode, string address, int age, int? daysOfVacation, decimal? height, decimal? weight, bool isFired, Guid uniqueIdentifier, EyeColor? eyeColor, Graduation graduation, Experience experience, DateTimeOffset? modifiedDate, DateTimeOffset birthDate, DateTimeOffset contraDateEnd, DateTimeOffset contraDateStart, string assignedOrganization)
        : base(name, lastName, nationalCode, personalCode, address, age, daysOfVacation, height, weight, isFired, uniqueIdentifier, eyeColor, graduation, experience, modifiedDate, birthDate, contraDateEnd, contraDateStart, assignedOrganization)
    {
        SetIdentity(id);
    }

    public static ChiefProductOfficer Create(int id, string name, string lastName, string nationalCode, string personalCode, string address, int age, int? daysOfVacation, decimal? height, decimal? weight, bool isFired, Guid uniqueIdentifier, EyeColor? eyeColor, Graduation graduation, Experience experience, DateTimeOffset? modifiedDate, DateTimeOffset birthDate, DateTimeOffset contraDateEnd, DateTimeOffset contraDateStart, string assignedOrganization)
    {
        return new ChiefProductOfficer(id, name, lastName, nationalCode, personalCode, address, age, daysOfVacation, height, weight, isFired, uniqueIdentifier, eyeColor, graduation, experience, modifiedDate, birthDate, contraDateEnd, contraDateStart, assignedOrganization);
    }

    public void AddLeadProductManager(ProductTeamLead productTeamLead)
    {
        ProductTeamLeads.Add(productTeamLead);
    }

    public void AddLeadScrumMaster(ScrumMasterTeamLead scrumMasterTeamLead)
    {
        ScrumMasterTeamLeads.Add(scrumMasterTeamLead);
    }

    public bool OnPatchCompleted()
    {
        return true;
    }
}