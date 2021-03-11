

namespace KiberlabLMS.ViewModels.Sections
{
    public class VideoSectionViewModel
    {
        public string Id { get; set; }

        public int Position { get; set; }
        public string VideoUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string LessonId { get; set; }
    }
}