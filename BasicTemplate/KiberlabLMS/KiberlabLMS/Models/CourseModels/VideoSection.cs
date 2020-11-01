using System.ComponentModel.DataAnnotations;

namespace KiberlabLMS.Models.CourseModels
{
    public class VideoSection : Section
    {
        [Required]
        public string VideoUrl { get; set; }
    }
}
