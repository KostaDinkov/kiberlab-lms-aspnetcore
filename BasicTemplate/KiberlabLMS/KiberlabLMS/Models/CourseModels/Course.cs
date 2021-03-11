using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KiberlabLMS.Models.Shared;
using KiberlabLMS.Models.State;
using Microsoft.AspNetCore.Http;

namespace KiberlabLMS.Models.CourseModels
{
    public class Course : BaseModel
    {
        private IFormFile imageData;

        public Course()
        {
            this.Lessons = new HashSet<Lesson>();
            this.CourseInstances = new HashSet<CourseInstance>();

            //this.Sections = new HashSet<Section>();
        }

        [MaxLength(50)] [Required] public string Name { get; set; }

        [MaxLength(300)] public string Description { get; set; }

        [Required] public string CourseCode { get; set; }

        
        

        public string ImageFilePath { get; set; }

        public ICollection<Lesson> Lessons { get; set; }

        public ICollection<CourseInstance> CourseInstances { get; set; }

        //public ICollection<Section> Sections { get; set; }
    }
}