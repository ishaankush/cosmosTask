
namespace cosmos.Models;
public class Detail
{
    public string? Id { get; set; }
    public string Title { get; set; }
    public string Summary { get; set; }
    public string Description { get; set; }
    public List<string> KeySkills { get; set; }
    public List<string> Benefits { get; set; }
    public ApplicationCriteriaModel ApplicationCriteria { get; set; }
    public string ProgramType { get; set; }
    public DateTime ProgramStart { get; set; }
    public DateTime ApplicationOpen { get; set; }
    public DateTime ApplicationClose { get; set; }
    public int DurationMonths { get; set; }
    public string ProgramLocation { get; set; }
    public int MinQualifications { get; set; }
    public int MaxApplications { get; set; }
}

public class ApplicationCriteriaModel
{
    public string Criteria { get; set; }
    public string InterviewProcess { get; set; }
}