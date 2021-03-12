using System.Collections.Generic;

namespace KiberlabLMS.ViewModels.Course
{
    public class CourseLessonsViewModel
    {
        public Models.CourseModels.Course Course { get; set; }

        public string CourseId { get; set; }

        public List<Models.CourseModels.Lesson> Lessons { get; set; }
    }
}
