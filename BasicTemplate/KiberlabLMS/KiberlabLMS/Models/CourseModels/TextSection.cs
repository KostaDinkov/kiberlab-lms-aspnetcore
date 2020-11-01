using System.ComponentModel.DataAnnotations;

namespace KiberlabLMS.Models.CourseModels
{
    public class TextSection : Section
    {
        [Required]
        public string HtmlString { get; set; }
    }
}
