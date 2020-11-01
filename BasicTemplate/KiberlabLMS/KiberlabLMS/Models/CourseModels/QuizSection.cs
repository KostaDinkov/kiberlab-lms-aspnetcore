using System.ComponentModel.DataAnnotations;

namespace KiberlabLMS.Models.CourseModels
{
    public class QuizSection : Section
    {
        // TODO create quiz subsystem
        [Required]
        public string Quiz { get; set; }
    }
}
