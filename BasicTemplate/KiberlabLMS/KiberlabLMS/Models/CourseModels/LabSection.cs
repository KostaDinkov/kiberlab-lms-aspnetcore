using System.ComponentModel.DataAnnotations;

namespace KiberlabLMS.Models.CourseModels
{
    public class LabSection : Section
    {
        public LabSection()
        {
            this.SectionType = SectionType.LabSection;
        }
        // TODO create the Lab subsystem
        [Required]
        public string Lab { get; set; }
    }
}
