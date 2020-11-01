using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KiberlabLMS.Data.Models.CourseModels
{
    public class QuizSection : Section
    {
        // TODO create quiz subsystem
        [Required]
        public string Quiz { get; set; }
    }
}
