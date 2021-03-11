using System.ComponentModel.DataAnnotations;

namespace KiberlabLMS.Models.CourseModels
{
    public class VideoSection : Section
    {
        [Required]
        public string VideoUrl { get; set; }
        [Required]
        public string Title { get; set; }
        
        public string Description { get; set; }
    }
}
