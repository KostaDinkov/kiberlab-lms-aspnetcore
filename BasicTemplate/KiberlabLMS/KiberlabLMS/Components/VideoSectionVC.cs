using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KiberlabLMS.Models.CourseModels;
using KiberlabLMS.ViewModels.Course;
using KiberlabLMS.ViewModels.Sections;
using Microsoft.AspNetCore.Mvc;

namespace KiberlabLMS.Components
{
    public class VideoSectionVC : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var videoLessonsViewModel = new VideoSectionViewModel();
            
            return this.View(videoLessonsViewModel);

        }
    }
}
