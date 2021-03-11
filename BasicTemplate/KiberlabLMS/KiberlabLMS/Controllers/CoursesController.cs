using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KiberlabLMS.Data;
using KiberlabLMS.Models.CourseModels;
using KiberlabLMS.ViewModels.Course;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;


namespace KiberlabLMS.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment environment;

        public CoursesController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            this.environment = environment;
            _context = context;
        }

        // GET: Courses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Courses.ToListAsync());
        }

        // GET: Courses/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses.Include(c=>c.Lessons)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: Courses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( CourseViewModel input)
        {
            if (ModelState.IsValid)
            {
                var course = new Course
                {
                    Name = input.Name,
                    Description = input.Description,
                    CourseCode = input.CourseCode
                };
                if (input.Image != null)
                {
                    var img = input.Image;
                    var uploadPath = Path.Combine(this.environment.WebRootPath, "uploads", input.CourseCode);
                    Directory.CreateDirectory(uploadPath);
                    var uniqueFileName = Utils.Utils.GetUniqueFileName(input.Image.FileName);
                    var filePath = Path.Combine(uploadPath, uniqueFileName);
                    
                    course.ImageFilePath = Path.Combine("uploads", input.CourseCode, uniqueFileName);
                    
                    //todo catch exception
                    var newFile = new FileStream(filePath, FileMode.Create);
                    await img.CopyToAsync(newFile);
                    newFile.Close();

                }

                _context.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(input);
        }

        // GET: Courses/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }

            var model = new CourseViewModel { Id = course.Id, Name= course.Name, Description = course.Description, CourseCode = course.CourseCode};
            return View(model);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,  CourseViewModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var course = this._context.Courses.FirstOrDefault(c => c.Id == id);
                    
                    course.Name = model.Name;
                    course.Description = model.Description;
                    course.CourseCode = model.CourseCode;

                    _context.Update(course);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(model.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Courses/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var course = await _context.Courses.FindAsync(id);
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseExists(string id)
        {
            return _context.Courses.Any(e => e.Id == id);
        }
    }
}
