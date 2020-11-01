using System;
using System.Linq;
using KiberlabLMS.Data.Models.CourseModels;

namespace KiberlabLMS.Data.Seeding
{
    public class CourseSeeder : ISeeder
    {
        public void Seed(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Courses.Any())
            {
                return;
            }

            // Create course with some demo data
            var course = new Course { Name = "Demo Course", CourseCode = "Demo", CreatedOn = DateTime.UtcNow, Description = "A demo course." };
            var unit = new Unit { Course = course, CourseId = course.Id, CreatedOn = DateTime.UtcNow, Description = "This is Unit 1 from the Demo course", Name = "Unit 1", Position = 100 };
            course.Units.Add(unit);
            var lesson = new Lesson { CreatedOn = DateTime.UtcNow, Name = "Lesson 1", Unit = unit, UnitId = unit.Id, Position = 100 };
            unit.Lessons.Add(lesson);
            var section1 = new TextSection
            {
                HtmlString = "<h1>Section 01</h1><h2>Introduction to Demo Course.</h2>",
                Position = 100,
                Lesson = lesson,
                LessonId = lesson.Id,
            };

            var section2 = new TextSection
            {
                HtmlString = "<h1>Section 02</h1><h2>What is Demo Course about?</h2>",
                Position = 200,
                Lesson = lesson,
                LessonId = lesson.Id,
            };

            var section3 = new TextSection
            {
                HtmlString = "<h1>Section 03</h1><h2>Section 3 is so cool.</h2>",
                Position = 300,
                Lesson = lesson,
                LessonId = lesson.Id,
            };
            lesson.Sections.Add(section1);
            lesson.Sections.Add(section2);
            lesson.Sections.Add(section3);

            course.Sections.Add(section1);
            course.Sections.Add(section2);
            course.Sections.Add(section3);


            dbContext.Courses.Add(course);
        }
    }
}
