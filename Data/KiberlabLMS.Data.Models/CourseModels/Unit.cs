using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using KiberlabLMS.Data.Common.Models;

namespace KiberlabLMS.Data.Models.CourseModels
{
    public class Unit : BaseModel
    {
        public Unit()
        {
            this.Lessons = new List<Lesson>();
        }

        /// <summary>
        /// Gets or sets the order position of the Unit in the Course.
        /// </summary>
        [Required]
        public double Position { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(300)]
        public string Description { get; set; }

        public string CourseId { get; set; }

        public Course Course { get; set; }

        public ICollection<Lesson> Lessons { get; set; }
    }
}
