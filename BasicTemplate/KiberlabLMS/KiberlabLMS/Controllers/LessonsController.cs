using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KiberlabLMS.Data;
using KiberlabLMS.Models.CourseModels;
using KiberlabLMS.ViewModels.Course;
using KiberlabLMS.ViewModels.Lesson;
using Microsoft.AspNetCore.Mvc;

namespace KiberlabLMS.Controllers
{
    public class LessonsController : Controller
    {

        private readonly ApplicationDbContext _context;

        public LessonsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<IActionResult> Edit(string id)
        {
            throw new  NotImplementedException();
        }

        public IActionResult Create(string courseId)
        {
            
            this.ViewData["courseId"] = courseId;
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateLessonViewModel model)
        {
            if (ModelState.IsValid)
            {
                var lesson = new Lesson
                {
                    Name = model.Name,
                    Description = model.Description,
                    CourseId = model.CourseId,
                    Position = model.Position
                };
                _context.Add(lesson);
                await _context.SaveChangesAsync();
                
                return this.RedirectToAction("Details","Courses", new {id = model.CourseId});
            }
            return View(model);
        }

        public Task<IActionResult> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Details(string id)
        {
            throw new NotImplementedException();
        }
    }
}
