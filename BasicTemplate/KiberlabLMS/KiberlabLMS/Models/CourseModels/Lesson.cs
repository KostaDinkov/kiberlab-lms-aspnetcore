using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KiberlabLMS.Models.CourseModels
{
    public class Lesson : BaseModel
    {
        public Lesson()
        {
            this.Sections = new HashSet<Section>();
        }

        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the order position of the Lesson in the Unit.
        /// </summary>
        public double Position { get; set; }

        public string UnitId { get; set; }

        public Unit Unit { get; set; }

        public ICollection<Section> Sections { get; set; }
    }
}
