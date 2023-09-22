using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cosmos.Models;

    public class Template
        
    {
         public string? Id { get; set; }
         public string CoverImage { get; set; } // Store image data or file path here
        public PersonalInformationModel PersonalInformation { get; set; }
        public ProfileModel Profile { get; set; }
        public List<QuestionModel> AdditionalQuestions { get; set; }
        public YesNoQuestionModel YesNoQuestion { get; set; }
    }
    public class PersonalInformationModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Nationality { get; set; }
        public string CurrentResidence { get; set; }
        public string IDNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
    }

    public class ProfileModel
    {
        public string Education { get; set; }
        public string Experience { get; set; }
        public string Resume { get; set; } // Store file data or file path here
    }

    public class QuestionModel
    {
        public string Type { get; set; } // "Paragraph," "Dropdown," etc.
        public string Question { get; set; } // The question itself
        public List<string> Choices { get; set; } // List of choices for Dropdown, or null for other types
        public bool Mandatory { get; set; } // Whether the question is mandatory
        public bool Show { get; set; } // Whether to show or hide the question
    }

    public class YesNoQuestionModel
    {
        public string Question { get; set; }
        public bool Mandatory { get; set; }
    }

