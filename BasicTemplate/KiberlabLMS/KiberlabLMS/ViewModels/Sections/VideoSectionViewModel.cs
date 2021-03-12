

using KiberlabLMS.Models.CourseModels;

namespace KiberlabLMS.ViewModels.Sections
{
    public class VideoSectionViewModel:ISectionViewModel
    {
        public string Id { get; set; }

        public int Position { get; set; }
        public string VideoUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LessonId { get; set; }
        public SectionType SectionType { get; set; }
    }
}