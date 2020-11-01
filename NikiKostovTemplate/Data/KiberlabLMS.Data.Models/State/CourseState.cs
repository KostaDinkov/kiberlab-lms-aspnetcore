using System.Collections.Generic;
using KiberlabLMS.Data.Common.Models;
using KiberlabLMS.Data.Models.User;

namespace KiberlabLMS.Data.Models.State
{
    public class CourseState : BaseModel
    {
        public CourseState()
        {
            this.SectionStates = new HashSet<SectionState>();
        }

        public CourseInstance CourseInstance { get; set; }

        public string CourseInstanceId { get; set; }

        public UserProfile UserProfile { get; set; }

        public string UserProfileId { get; set; }

        public ICollection<SectionState> SectionStates { get; set; }
    }
}
