

using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using Microsoft.AspNetCore.Http;

namespace KiberlabLMS.ViewModels.Course
{
    public class CourseViewModel
    {
        public string Id { get; set; }

        [Required]
        [StringLength(20,MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 10)]
        public string Description { get; set; }

        [Required]
        public string CourseCode { get; set; }

        
        public IFormFile Image { get; set; }
    }
}
