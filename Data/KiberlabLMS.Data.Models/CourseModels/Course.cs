using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using KiberlabLMS.Data.Common.Models;
using KiberlabLMS.Data.Models.State;

namespace KiberlabLMS.Data.Models.CourseModels
{
    public class Course : BaseModel
    {
        public Course()
        {
            this.Units = new HashSet<Unit>();
            this.CourseInstances = new HashSet<CourseInstance>();
        }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }

        [Required]
        public string CourseCode { get; set; }

        [Required]
        public string InstanceCode { get; set; }

        public byte[] ImageData { get; set; }

        public ICollection<Unit> Units { get; set; }

        public ICollection<CourseInstance> CourseInstances { get; set; }
    }
}
