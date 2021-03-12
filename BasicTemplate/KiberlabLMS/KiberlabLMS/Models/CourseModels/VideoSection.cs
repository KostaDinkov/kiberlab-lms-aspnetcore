using System.ComponentModel.DataAnnotations;

namespace KiberlabLMS.Models.CourseModels
{
    public class VideoSection : Section
    {

        public VideoSection()
        {
            this.SectionType = SectionType.VideoSection;
        }
        [Required]
        public string VideoUrl { get; set; }
        
        public string Description { get; set; }
    }
}
