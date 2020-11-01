using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KiberlabLMS.Data.Models.CourseModels
{
    public class TextSection : Section
    {
        [Required]
        public string HtmlString { get; set; }
    }
}
