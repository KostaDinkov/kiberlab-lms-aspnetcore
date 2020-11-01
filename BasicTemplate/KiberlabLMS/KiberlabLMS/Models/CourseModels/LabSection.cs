using System.ComponentModel.DataAnnotations;

namespace KiberlabLMS.Models.CourseModels
{
    public class LabSection : Section
    {
        // TODO create the Lab subsystem
        [Required]
        public string Lab { get; set; }
    }
}
