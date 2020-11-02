using System.Collections.Generic;
using KiberlabLMS.Models.User;

namespace KiberlabLMS.Models.State
{
    public class CourseState : BaseModel
    {
        public CourseState()
        {
            this.SectionStates = new HashSet<SectionState>();
        }

        public CourseInstance CourseInstance { get; set; }

        public string CourseInstanceId { get; set; }

        public UserProgress UserProgress { get; set; }

        public string UserProgressId { get; set; }

        public ICollection<SectionState> SectionStates { get; set; }
    }
}
