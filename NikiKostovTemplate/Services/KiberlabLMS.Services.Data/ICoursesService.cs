using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using KiberlabLMS.Data.Models.CourseModels;

namespace KiberlabLMS.Services.Data
{
    public interface ICoursesService
    {
        IQueryable<Course> GetAll();

        Course GetById(string id);
    }
}