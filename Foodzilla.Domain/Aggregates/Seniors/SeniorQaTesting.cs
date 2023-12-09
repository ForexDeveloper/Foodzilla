﻿using Foodzilla.Kernel.Patch;
using Foodzilla.Domain.Aggregates.TeamLeads;

namespace Foodzilla.Domain.Aggregates.Seniors;

public sealed class SeniorQaTesting : Identity<long>, IPatchValidator
{
    public int QaTestingTeamLeadId { get; private set; }

    public QaTestingTeamLead? QaTestingTeamLead { get; init; }

    private SeniorQaTesting(long id, string name, string lastName, string nationalCode, string personalCode, string address, int age, int? daysOfVacation, decimal? height, decimal? weight, bool isFired, Guid uniqueIdentifier, EyeColor? eyeColor, Graduation graduation, Experience experience, DateTimeOffset? modifiedDate, DateTimeOffset birthDate, DateTimeOffset contraDateEnd, DateTimeOffset contraDateStart, int qaTestingTeamLeadId)
        : base(name, lastName, nationalCode, personalCode, address, age, daysOfVacation, height, weight, isFired, uniqueIdentifier, eyeColor, graduation, experience, modifiedDate, birthDate, contraDateEnd, contraDateStart)
    {
        SetIdentity(id);
        //QaTestingTeamLeadId = qaTestingTeamLeadId;
    }

    private SeniorQaTesting()
    {

    }

    public static SeniorQaTesting Create(long id, string name, string lastName, string nationalCode, string personalCode, string address, int age, int? daysOfVacation, decimal? height, decimal? weight, bool isFired, Guid uniqueIdentifier, EyeColor? eyeColor, Graduation graduation, Experience experience, DateTimeOffset? modifiedDate, DateTimeOffset birthDate, DateTimeOffset contraDateEnd, DateTimeOffset contraDateStart, int qaTestingTeamLeadId)
    {
        return new SeniorQaTesting(id, name, lastName, nationalCode, personalCode, address, age, daysOfVacation, height, weight, isFired, uniqueIdentifier, eyeColor, graduation, experience, modifiedDate, birthDate, contraDateEnd, contraDateStart, qaTestingTeamLeadId);
    }

    public bool OnPatchCompleted()
    {
        return true;
    }
}