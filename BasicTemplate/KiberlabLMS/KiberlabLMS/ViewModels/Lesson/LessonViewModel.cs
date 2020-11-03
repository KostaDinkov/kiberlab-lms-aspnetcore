using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using KiberlabLMS.Models.CourseModels;

namespace KiberlabLMS.ViewModels.Lesson
{
    public class LessonViewModel
    {
        public string Id { get; set; }
        
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the order position of the Lesson in the Unit.
        /// </summary>
        public double Position { get; set; }

        public string Description { get; set; }

        public string CourseId { get; set; }
        
    }
}
