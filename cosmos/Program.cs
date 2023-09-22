using Microsoft.EntityFrameworkCore;
using cosmos.Data;
using cosmos.Models;
    
using (var cosmosContext = new CosmosContext())
{
    var detail1 = new Detail()
    {
        Id = Guid.NewGuid().ToString(),
        Title = "Summer Internship Program",
        Summary = "Exciting summer internship opportunity",
        Description = "Our summer internship program offers valuable experience in a dynamic environment.",
        KeySkills = new List<string> { "Communication", "Problem Solving", "Teamwork" },
        Benefits = new List<string>
    {
        "Hands-on experience",
        "Mentorship",
        "Networking opportunities"
    },
        ApplicationCriteria = new ApplicationCriteriaModel
        {
            Criteria = "Bachelor's degree or equivalent",
            InterviewProcess = "Phone interview, technical test, in-person interview"
        },
        ProgramType = "Full Time",
        ProgramStart = new DateTime(2023, 7, 1),
        ApplicationOpen = new DateTime(2023, 4, 1),
        ApplicationClose = new DateTime(2023, 5, 15),
        DurationMonths = 6,
        ProgramLocation = "London, UK",
        MinQualifications = 20_000,
        MaxApplications = 50

    };
   
    cosmosContext.Details?.Add(detail1);

    await cosmosContext.SaveChangesAsync();

    Console.WriteLine("Employee records inserted successfully...");
}