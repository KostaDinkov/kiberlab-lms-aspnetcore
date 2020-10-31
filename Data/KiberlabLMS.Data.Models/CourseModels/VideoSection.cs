using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KiberlabLMS.Data.Models.CourseModels
{
    public class VideoSection : Section
    {
        [Required]
        public string VideoUrl { get; set; }
    }
}
