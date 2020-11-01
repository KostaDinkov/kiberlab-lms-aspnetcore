using KiberlabLMS.Data.Models.CourseModels;
using KiberlabLMS.Services.Mapping;

namespace KiberlabLMS.Web.ViewModels.Courses
{
    public class CourseViewModel:IMapFrom<Course>
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string CourseCode { get; set; }
    }
}
