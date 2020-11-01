using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KiberlabLMS.Data.Models.CourseModels
{
    public class LabSection : Section
    {
        // TODO create the Lab subsystem
        [Required]
        public string Lab { get; set; }
    }
}
