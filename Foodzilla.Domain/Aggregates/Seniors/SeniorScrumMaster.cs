using Foodzilla.Kernel.Patch;
using Foodzilla.Domain.Aggregates.TeamLeads;

namespace Foodzilla.Domain.Aggregates.Seniors;

public sealed class SeniorScrumMaster : Identity<long>, IPatchValidator
{
    public int ScrumMasterTeamLeadId { get; private set; }

    public ScrumMasterTeamLead? ScrumMasterTeamLead { get; private set; }

    private SeniorScrumMaster(long id, string name, string lastName, string nationalCode, string personalCode, string address, int age, int? daysOfVacation, decimal? height, decimal? weight, bool isFired, Guid uniqueIdentifier, EyeColor? eyeColor, Graduation graduation, Experience experience, DateTimeOffset? modifiedDate, DateTimeOffset birthDate, DateTimeOffset contraDateEnd, DateTimeOffset contraDateStart, int scrumMasterTeamLeadId)
        : base(name, lastName, nationalCode, personalCode, address, age, daysOfVacation, height, weight, isFired, uniqueIdentifier, eyeColor, graduation, experience, modifiedDate, birthDate, contraDateEnd, contraDateStart)
    {
        SetIdentity(id);
        //ScrumMasterTeamLeadId = scrumMasterTeamLeadId;
    }

    private SeniorScrumMaster()
    {

    }

    public static SeniorScrumMaster Create(long id, string name, string lastName, string nationalCode, string personalCode, string address, int age, int? daysOfVacation, decimal? height, decimal? weight, bool isFired, Guid uniqueIdentifier, EyeColor? eyeColor, Graduation graduation, Experience experience, DateTimeOffset? modifiedDate, DateTimeOffset birthDate, DateTimeOffset contraDateEnd, DateTimeOffset contraDateStart, int scrumMasterTeamLeadId)
    {
        return new SeniorScrumMaster(id, name, lastName, nationalCode, personalCode, address, age, daysOfVacation, height, weight, isFired, uniqueIdentifier, eyeColor, graduation, experience, modifiedDate, birthDate, contraDateEnd, contraDateStart, scrumMasterTeamLeadId);
    }

    public bool OnPatchCompleted()
    {
        return true;
    }
}