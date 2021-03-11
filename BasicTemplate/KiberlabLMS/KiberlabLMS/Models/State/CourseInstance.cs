using System;
using System.ComponentModel.DataAnnotations;
using KiberlabLMS.Models.CourseModels;
using KiberlabLMS.Models.Shared;

namespace KiberlabLMS.Models.State
{
    public class CourseInstance : BaseModel
    {
       

        public Course Course { get; set; }

        public string CourseId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

    }
}
