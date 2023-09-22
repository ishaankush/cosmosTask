using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cosmos.Models;



    public class Webflow
    {
    public string? Id { get; set; }
    public string StageName { get; set; } // Example: "1st Round of Interview"
        public StageType StageType { get; set; } // Enum representing Shortlisting, Interview, etc.
        public bool EvaluateWithVideoInterview { get; set; } // Whether to evaluate candidates with video interviews
        public List<VideoInterviewQuestionModel> VideoInterviewQuestions { get; set; } // List of video interview questions
        public string AdditionalInformation { get; set; } // Additional information about the stage
        public int MaxVideoDurationSeconds { get; set; } // Max duration of video in seconds
        public int DeadlineDays { get; set; } // Deadline for video submission in days
        public bool HideFromCandidate { get; set; } // Whether to hide the stage from candidates
    }

    public enum StageType
    {
        Shortlisting,
        Interview,
        Placement,
        // Add more stage types as needed
    }

    public class VideoInterviewQuestionModel
    {
        public string Question { get; set; } // The video interview question
    }


