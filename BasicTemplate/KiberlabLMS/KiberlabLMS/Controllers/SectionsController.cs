using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KiberlabLMS.Data;
using KiberlabLMS.Models.CourseModels;
using KiberlabLMS.ViewModels.Sections;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace KiberlabLMS.Controllers
{
    public class SectionsController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly ILogger logger;

        public SectionsController(ApplicationDbContext context, ILogger<SectionsController> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public IActionResult Create(string lessonId, SectionType sectionType)
        {
            this.ViewData["lessonId"] = lessonId;
            this.ViewData["sectionType"] = sectionType;
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateVideoSection(VideoSectionViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                var videoSection = new VideoSection()
                {
                    VideoUrl = model.VideoUrl,
                    Position = model.Position,
                    Name = model.Name,
                    Description = model.Description,
                    LessonId = model.LessonId
                };
                context.Add(videoSection);
                await context.SaveChangesAsync();
            }

            return this.RedirectToAction("Details", "Lessons", new {id = model.LessonId});
        }

        public IActionResult Details(string id)
        {
            var model = this.context.VideoSections
                .Include(s => s.Lesson)
                .FirstOrDefault(s => s.Id == id);

            if (model == null) return this.NotFound();

            switch (model.SectionType)
            {
                case SectionType.VideoSection:
                    return this.View("VideoSectionDetails", model);
            }

            return this.NotFound();
        }

        public IActionResult Edit(string id, SectionType sectionType)
        {
            this.ViewData["sectionId"] = id;
            switch (sectionType)
            {
                case SectionType.VideoSection:
                    var model = this.context.VideoSections
                        .Include(s => s.Lesson)
                        .FirstOrDefault(s => s.Id == id);
                    if (model == null) return this.NotFound();

                    var viewModel = new VideoSectionViewModel()
                    {
                        Name = model.Name,
                        Description = model.Description,
                        SectionType = model.SectionType,
                        Id = model.Id,
                        LessonId = model.LessonId,
                        VideoUrl = model.VideoUrl
                    };
                    return this.View("EditVideoSection",viewModel);
            }

            return this.NotFound();
        }

        public IActionResult Delete(string id, SectionType sectionType)
        {
            switch (sectionType)
            {
                case SectionType.VideoSection:
                    var model = this.context.VideoSections.Include(s=>s.Lesson).FirstOrDefault(s => s.Id == id);
                    var viewModel = new SectionViewModel()
                    {
                        Id = model.Id,
                        Lesson = model.Lesson,
                        LessonId = model.LessonId,
                        Name = model.Name,
                        Position = model.Position,
                        SectionType = model.SectionType

                    };
                    return this.View(viewModel);
                    
            }

            return this.NotFound();

        }
        [HttpPost]
        public async Task<IActionResult> Delete(string id, SectionViewModel viewModel)
        {
            switch (viewModel.SectionType)
            {
                case SectionType.VideoSection:
                    var section = await this.context.VideoSections.FirstOrDefaultAsync(s=>s.Id == id);
                    this.context.VideoSections.Remove(section);
                    await this.context.SaveChangesAsync();
                    return this.RedirectToAction("Details", "Lessons", new {id = section.LessonId});

            }

            return this.NotFound();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditVideoSection(string id, VideoSectionViewModel model)
        {
            this.logger.LogInformation(id);
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var section = this.context.VideoSections.FirstOrDefault(c => c.Id == id);
                    model.LessonId = section.LessonId;
                    section.Name = model.Name;
                    section.Description = model.Description;
                    section.VideoUrl = model.VideoUrl;
                    section.Position = model.Position;

                    context.Update(section);
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!context.VideoSections.Any(c => c.Id == model.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction("Details", "Lessons", new {id = model.LessonId});
            }

            return this.NotFound();
        }
    }
}