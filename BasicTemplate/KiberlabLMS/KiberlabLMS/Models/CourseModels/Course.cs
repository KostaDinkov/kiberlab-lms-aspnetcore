using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using KiberlabLMS.Models.State;

namespace KiberlabLMS.Models.CourseModels
{
    public class Course : BaseModel
    {
        public Course()
        {
            this.Units = new HashSet<Unit>();
            this.CourseInstances = new HashSet<CourseInstance>();
            this.Sections = new HashSet<Section>();
        }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }

        [Required]
        public string CourseCode { get; set; }

        public byte[] ImageData { get; set; }

        public ICollection<Unit> Units { get; set; }

        public ICollection<CourseInstance> CourseInstances { get; set; }

        public ICollection<Section> Sections { get; set; }
    }
}
