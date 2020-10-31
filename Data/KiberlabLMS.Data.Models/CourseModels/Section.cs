using System.ComponentModel.DataAnnotations;
using KiberlabLMS.Data.Common.Models;
using KiberlabLMS.Data.Models.State;

namespace KiberlabLMS.Data.Models.CourseModels
{
    public abstract class Section : BaseModel
    {
        public Lesson Lesson { get; set; }

        public string LessonId { get; set; }

        public SectionState SectionState { get; set; }

        [Required]
        public double Position { get; set; }
    }
}
