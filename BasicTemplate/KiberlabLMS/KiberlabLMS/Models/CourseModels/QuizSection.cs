using System.ComponentModel.DataAnnotations;

namespace KiberlabLMS.Models.CourseModels
{
    public class QuizSection : Section
    {
        public QuizSection()
        {
            this.SectionType = SectionType.QuizSection;
        }
        // TODO create quiz subsystem
        [Required]
        public string Quiz { get; set; }
    }
}
