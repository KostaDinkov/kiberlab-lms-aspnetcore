using System.ComponentModel.DataAnnotations;
using KiberlabLMS.Models.Shared;
using KiberlabLMS.Models.State;

namespace KiberlabLMS.Models.CourseModels
{
    public abstract class Section : BaseModel
    {
        public Lesson Lesson { get; set; }

        public SectionType SectionType {get; set; }

        public string LessonId { get; set; }

        public SectionState SectionState { get; set; }

        [Required]
        public double Position { get; set; }

        [Required]
        public string Name { get; set; }


    }
}
