﻿using Foodzilla.Domain.Aggregates.ChiefOfficers;
using Foodzilla.Domain.Aggregates.Seniors;
using Foodzilla.Kernel.Patch;

namespace Foodzilla.Domain.Aggregates.TeamLeads;

public sealed class TechnicalTeamLead : Identity<int>, IPatchValidator
{
    public int ChiefTechnicalOfficerId { get; private set; }

    public ChiefTechnicalOfficer? ChiefTechnicalOfficer { get; init; }

    public List<SeniorDeveloper> Seniors { get; init; } = new List<SeniorDeveloper>();

    private TechnicalTeamLead(int id, string name, string lastName, string nationalCode, string personalCode, string address, int age, int? daysOfVacation, decimal? height, decimal? weight, bool isFired, Guid uniqueIdentifier, EyeColor? eyeColor, Graduation graduation, Experience experience, DateTimeOffset? modifiedDate, DateTimeOffset birthDate, DateTimeOffset contraDateEnd, DateTimeOffset contraDateStart, int chiefTechnicalOfficerId)
        : base(name, lastName, nationalCode, personalCode, address, age, daysOfVacation, height, weight, isFired, uniqueIdentifier, eyeColor, graduation, experience, modifiedDate, birthDate, contraDateEnd, contraDateStart)
    {
        SetIdentity(id);
        ChiefTechnicalOfficerId = chiefTechnicalOfficerId;
    }

    public static TechnicalTeamLead Create(int id, string name, string lastName, string nationalCode, string personalCode, string address, int age, int? daysOfVacation, decimal? height, decimal? weight, bool isFired, Guid uniqueIdentifier, EyeColor? eyeColor, Graduation graduation, Experience experience, DateTimeOffset? modifiedDate, DateTimeOffset birthDate, DateTimeOffset contraDateEnd, DateTimeOffset contraDateStart, int chiefTechnicalOfficerId)
    {
        return new TechnicalTeamLead(id, name, lastName, nationalCode, personalCode, address, age, daysOfVacation, height, weight, isFired, uniqueIdentifier, eyeColor, graduation, experience, modifiedDate, birthDate, contraDateEnd, contraDateStart, chiefTechnicalOfficerId);
    }

    public void AddSeniorTechnical(SeniorDeveloper senior)
    {
        Seniors.Add(senior);
    }

    public bool OnPatchCompleted()
    {
        return true;
    }
}