using System.ComponentModel.DataAnnotations;

namespace KiberlabLMS.Models.CourseModels
{
    public class TextSection : Section
    {
        public TextSection()
        {
            this.SectionType = SectionType.TextSection;
        }
        [Required]
        public string HtmlString { get; set; }
    }
}
