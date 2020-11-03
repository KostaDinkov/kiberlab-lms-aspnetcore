using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KiberlabLMS.Data;
using KiberlabLMS.Models.CourseModels;
using KiberlabLMS.ViewModels.Course;
using KiberlabLMS.ViewModels.Lesson;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KiberlabLMS.Controllers
{
    public class LessonsController : Controller
    {

        private readonly ApplicationDbContext _context;

        public LessonsController(ApplicationDbContext context)
        {
            _context = context;
        }
        

        public IActionResult Create(string courseId)
        {
            
            this.ViewData["courseId"] = courseId;
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LessonViewModel model)
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

        

        public IActionResult Details(string id)
        {
            var model = this._context.Lessons.Include(l => l.Course).FirstOrDefault(lesson => lesson.Id == id);
            
            return this.View(model);
        }

        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lesson = await _context.Lessons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lesson == null)
            {
                return NotFound();
            }

            return View(lesson);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var lesson = await _context.Lessons.FindAsync(id);
            _context.Lessons.Remove(lesson);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details","Courses", new {id = lesson.CourseId});
        }

        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lesson = await _context.Lessons.FindAsync(id);
            if (lesson == null)
            {
                return NotFound();
            }

            var model = new LessonViewModel() { Id = lesson.Id, Name = lesson.Name, Description = lesson.Description, Position = lesson.Position, CourseId = lesson.CourseId};
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, LessonViewModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var lesson = this._context.Lessons.FirstOrDefault(c => c.Id == id);

                    lesson.Name = model.Name;
                    lesson.Description = model.Description;
                    lesson.CourseId = model.CourseId;
                    lesson.Position = model.Position;
                    

                    _context.Update(lesson);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LessonExists(model.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Courses", new {id = model.CourseId});
            }
            return View(model);
        }

        private bool LessonExists(string id)
        {
            return _context.Lessons.Any(e => e.Id == id);
        }
    }
}
