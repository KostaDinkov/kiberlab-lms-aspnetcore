
using System.Linq;
using System.Threading.Tasks;
using KiberlabLMS.Models.CourseModels;
using KiberlabLMS.ViewModels.Course;
using Microsoft.AspNetCore.Mvc;

namespace KiberlabLMS.Components
{
    public class LessonsListViewComponent:ViewComponent
    {
        public  IViewComponentResult Invoke(Course course)
        {
            var courseLessonsModel = new CourseLessonsViewModel
            {
                Course = course,
                CourseId = course.Id,
                Lessons = course.Lessons.OrderBy(lesson => lesson.Position).ToList(),
            };
            return this.View(courseLessonsModel);
        }
    }
}
