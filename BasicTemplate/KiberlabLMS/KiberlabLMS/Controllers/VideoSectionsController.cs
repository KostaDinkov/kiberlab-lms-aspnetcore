using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KiberlabLMS.Data;
using KiberlabLMS.Models.CourseModels;
using KiberlabLMS.ViewModels.Sections;

namespace KiberlabLMS.Controllers
{
    public class VideoSectionsController : Controller
    {
        private readonly ApplicationDbContext context;

        public VideoSectionsController(ApplicationDbContext context )
        {
            this.context = context;
        }
        public IActionResult Create(string lessonId)
        {
            this.ViewData["lessonId"] = lessonId;
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VideoSectionViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                var videoSection = new VideoSection()
                {
                    VideoUrl = model.VideoUrl,
                    Position = model.Position,
                    Title = model.Title,
                    Description = model.Description,
                    LessonId = model.LessonId
                };
                context.Add(videoSection);
                await context.SaveChangesAsync();

                return this.RedirectToAction("Details", "Lessons", new { id = model.LessonId });
            }

            throw new NotFiniteNumberException();
        }
    }
}
