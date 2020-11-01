using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KiberlabLMS.Data.Common.Repositories;
using KiberlabLMS.Data.Models.CourseModels;
using KiberlabLMS.Services.Mapping;

namespace KiberlabLMS.Services.Data
{
    public class CoursesService: ICoursesService
    {
        private readonly IRepository<Course> coursesRepository;

        public CoursesService(IRepository<Course> coursesRepository)
        {
            this.coursesRepository = coursesRepository;
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.coursesRepository.All().To<T>().ToList();
        }

        public T GetById<T>(string id)
        {
            throw new NotImplementedException();
        }
    }
}
