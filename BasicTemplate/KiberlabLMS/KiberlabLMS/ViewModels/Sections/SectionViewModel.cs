using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using KiberlabLMS.Models.CourseModels;
using KiberlabLMS.Models.State;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace KiberlabLMS.ViewModels.Sections
{
    public class SectionViewModel
    {
        public string Id { get; set; }
        public SectionType SectionType { get; set; }
        public Models.CourseModels.Lesson Lesson { get; set; }
        public string LessonId { get; set; }

        public double Position { get; set; }

        public string Name { get; set; }
    }
}
