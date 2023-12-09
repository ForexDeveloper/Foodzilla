﻿using Foodzilla.Kernel.Patch;
using Foodzilla.Domain.Aggregates.Midlevels;
using Foodzilla.Domain.Aggregates.TeamLeads;

namespace Foodzilla.Domain.Aggregates.Seniors;

public sealed class SeniorMarketing : Identity<long>, IPatchValidator
{
    public int MarketingTeamLeadId { get; private set; }

    public MarketingTeamLead? MarketingTeamLead { get; init; }

    public List<MidlevelMarketing> Midlevels { get; init; } = new List<MidlevelMarketing>();

    private SeniorMarketing(long id, string name, string lastName, string nationalCode, string personalCode, string address, int age, int? daysOfVacation, decimal? height, decimal? weight, bool isFired, Guid uniqueIdentifier, EyeColor? eyeColor, Graduation graduation, Experience experience, DateTimeOffset? modifiedDate, DateTimeOffset birthDate, DateTimeOffset contraDateEnd, DateTimeOffset contraDateStart, int marketingTeamLeadId)
        : base(name, lastName, nationalCode, personalCode, address, age, daysOfVacation, height, weight, isFired, uniqueIdentifier, eyeColor, graduation, experience, modifiedDate, birthDate, contraDateEnd, contraDateStart)
    {
        SetIdentity(id);
        //MarketingTeamLeadId = marketingTeamLeadId;
    }

    private SeniorMarketing()
    {

    }

    public static SeniorMarketing Create(long id, string name, string lastName, string nationalCode, string personalCode, string address, int age, int? daysOfVacation, decimal? height, decimal? weight, bool isFired, Guid uniqueIdentifier, EyeColor? eyeColor, Graduation graduation, Experience experience, DateTimeOffset? modifiedDate, DateTimeOffset birthDate, DateTimeOffset contraDateEnd, DateTimeOffset contraDateStart, int marketingTeamLeadId)
    {
        return new SeniorMarketing(id, name, lastName, nationalCode, personalCode, address, age, daysOfVacation, height, weight, isFired, uniqueIdentifier, eyeColor, graduation, experience, modifiedDate, birthDate, contraDateEnd, contraDateStart, marketingTeamLeadId);
    }

    public void AddMidlevelMarketing(MidlevelMarketing midlevel)
    {
        Midlevels.Add(midlevel);
    }

    public bool OnPatchCompleted()
    {
        return true;
    }
}