﻿using Foodzilla.Kernel.Patch;
using Foodzilla.Domain.Aggregates.Midlevels;
using Foodzilla.Domain.Aggregates.TeamLeads;

namespace Foodzilla.Domain.Aggregates.Seniors;

public sealed class SeniorProductManager : Identity<long>, IPatchValidator
{
    public int ProductTeamLeadId { get; private set;}

    public ProductTeamLead? ProductTeamLead { get; init; }

    public List<MidlevelProductManager> Midlevels { get; init; } = new List<MidlevelProductManager>();

    private SeniorProductManager(long id, string name, string lastName, string nationalCode, string personalCode, string address, int age, int? daysOfVacation, decimal? height, decimal? weight, bool isFired, Guid uniqueIdentifier, EyeColor? eyeColor, Graduation graduation, Experience experience, DateTimeOffset? modifiedDate, DateTimeOffset birthDate, DateTimeOffset contraDateEnd, DateTimeOffset contraDateStart, int productTeamLeadId)
        : base(name, lastName, nationalCode, personalCode, address, age, daysOfVacation, height, weight, isFired, uniqueIdentifier, eyeColor, graduation, experience, modifiedDate, birthDate, contraDateEnd, contraDateStart)
    {
        SetIdentity(id);
        ProductTeamLeadId = productTeamLeadId;
    }

    private SeniorProductManager()
    {

    }

    public static SeniorProductManager Create(long id, string name, string lastName, string nationalCode, string personalCode, string address, int age, int? daysOfVacation, decimal? height, decimal? weight, bool isFired, Guid uniqueIdentifier, EyeColor? eyeColor, Graduation graduation, Experience experience, DateTimeOffset? modifiedDate, DateTimeOffset birthDate, DateTimeOffset contraDateEnd, DateTimeOffset contraDateStart, int productTeamLeadId)
    {
        return new SeniorProductManager(id, name, lastName, nationalCode, personalCode, address, age, daysOfVacation, height, weight, isFired, uniqueIdentifier, eyeColor, graduation, experience, modifiedDate, birthDate, contraDateEnd, contraDateStart, productTeamLeadId);
    }

    public void AddMidlevelProductManager(MidlevelProductManager midlevel)
    {
        Midlevels.Add(midlevel);
    }

    public bool OnPatchCompleted()
    {
        return true;
    }
}