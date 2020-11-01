using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KiberlabLMS.Data.Common.Repositories;
using KiberlabLMS.Data.Models;
using KiberlabLMS.Data.Models.CourseModels;
using KiberlabLMS.Services.Data;
using KiberlabLMS.Web.ViewModels.Courses;
using KiberlabLMS.Web.ViewModels.Settings;
using Microsoft.AspNetCore.Mvc;

namespace KiberlabLMS.Web.Controllers
{
    public class CoursesController: BaseController
    {
        private readonly ICoursesService coursesService;

        private readonly IRepository<Course> repository;

        public CoursesController (ICoursesService coursesService, IRepository<Course> repository)
        {
            this.coursesService = coursesService;
            this.repository = repository;
        }

        public IActionResult Index()
        {
            var model = this.coursesService.GetAll<CourseViewModel>().ToList();
            
            return this.View(model);
        }

        
    }

    
}
