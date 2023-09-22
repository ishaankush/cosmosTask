using Microsoft.EntityFrameworkCore;
using cosmos.Data;
using cosmos.Models;
    
using (var cosmosContext = new CosmosContext())
{  
    //post detail page
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

    Console.WriteLine("details records inserted successfully...");

    


    //post template page
    var template = new Template
    {
        Id = Guid.NewGuid().ToString(),
        CoverImage = "sample-image.jpg",
        PersonalInformation = new PersonalInformationModel
        {
            FirstName = "John",
            LastName = "Doe",
            Email = "johndoe@example.com",
            Phone = "123-456-7890",
            Nationality = "US",
            CurrentResidence = "New York",
            IDNumber = "12345",
            DateOfBirth = new DateTime(1990, 1, 15),
            Gender = "Male"
        },
        Profile = new ProfileModel
        {
            Education = "Bachelor's in Computer Science",
            Experience = "5 years of software development",
            Resume = "sample-resume.pdf"
        },
        AdditionalQuestions = new List<QuestionModel>
                {
                    new QuestionModel
                    {
                        Type = "Paragraph",
                        Question = "Tell us about your work experience.",
                        Mandatory = true,
                        Show = true
                    },
                    new QuestionModel
                    {
                        Type = "Dropdown",
                        Question = "Select your preferred programming language",
                        Choices = new List<string> { "C#", "Java", "Python" },
                        Mandatory = true,
                        Show = true
                    }
                },
        YesNoQuestion = new YesNoQuestionModel
        {
            Question = "Have you worked on a similar project before?",
            Mandatory = true
        }
    };
    cosmosContext.Templates?.Add(template);

    await cosmosContext.SaveChangesAsync();

    Console.WriteLine("template records inserted successfully...");



    //post webflow page
    var webflow = new Webflow
    {   

        StageName = "1st Round of Interview",
        StageType = StageType.Interview,
        EvaluateWithVideoInterview = true,
        VideoInterviewQuestions = new List<VideoInterviewQuestionModel>
                {
                    new VideoInterviewQuestionModel
                    {
                        Question = "What is your experience with C#?"
                    },
                    new VideoInterviewQuestionModel
                    {
                        Question = "Describe a challenging project you've worked on."
                    }
                },
        AdditionalInformation = "Please prepare for a technical interview.",
        MaxVideoDurationSeconds = 300, // 5 minutes
        DeadlineDays = 7, // 7 days from the stage start
        HideFromCandidate = false
    };
    cosmosContext.Webflows?.Add(webflow);

    await cosmosContext.SaveChangesAsync();

    Console.WriteLine("Webflow records inserted successfully...");




    // Get Detail of all data for preview page

    if (cosmosContext.Details != null && cosmosContext.Templates != null && cosmosContext.Webflows != null)
    {
        var Details = await cosmosContext.Details.ToListAsync();
        var Templates = await cosmosContext.Templates.ToListAsync();
        var Webflows = await cosmosContext.Webflows.ToListAsync();
        Console.WriteLine("");

        foreach (var detail in Details)
        {
            Console.WriteLine("Title: " + (detail?.Title ?? "N/A")); 
            Console.WriteLine("Summary: " + (detail?.Summary ?? "N/A")); 
            Console.WriteLine("--------------------------------\n");
        }

        // we can create all for each for webflows and details in the same way to get data
    }

   
}