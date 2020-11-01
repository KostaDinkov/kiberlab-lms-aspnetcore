using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KiberlabLMS.Data.Models.State;

namespace KiberlabLMS.Data.Seeding
{
    public class EnrollmentSeeder : ISeeder
    {
        public void Seed(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.CourseStates.Any())
            {
                return;
            }

            var course = dbContext.Courses.FirstOrDefault(c => c.Name == "Demo Course");
            var courseInstance = new CourseInstance { Course = course, CourseId = course.Id, StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow.AddMonths(3) };
            var userProfile = dbContext.UserProfiles.FirstOrDefault();
            var courseState = new CourseState { UserProfile = userProfile, UserProfileId = userProfile.Id, CourseInstance = courseInstance, CourseInstanceId = courseInstance.Id};

            var sectionStates = new HashSet<SectionState>();
            foreach (var section in course.Sections)
            {
                sectionStates.Add(new SectionState
                {
                    IsComplete = false,
                    CourseState = courseState,
                    CourseStateId = courseState.Id,
                    Section = section,
                    SectionId = section.Id,
                    IsLocked = true,
                });
            }

            courseState.SectionStates = sectionStates;
            userProfile.CourseStates.Add(courseState);
            courseInstance.UserProfiles.Add(userProfile);
            dbContext.CourseStates.Add(courseState);
        }
    }
}
