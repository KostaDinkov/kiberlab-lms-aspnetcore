using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using KiberlabLMS.Models.CourseModels;

namespace KiberlabLMS.ViewModels.Course
{
    public class CourseLessonsViewModel
    {
        public Models.CourseModels.Course Course { get; set; }

        public string CourseId { get; set; }

        public List<Models.CourseModels.Lesson> Lessons { get; set; }
    }
}
