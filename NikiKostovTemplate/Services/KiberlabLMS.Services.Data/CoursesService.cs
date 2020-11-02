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

        public CoursesService(CourseRepository coursesRepository)
        {
            this.coursesRepository = coursesRepository;
        }

        public IQueryable<Course> GetAll()
        {
            return this.coursesRepository.All();
        }

        public Course GetById(string id)
        {
            return this.coursesRepository.GetById(id);
        }
    }
}
