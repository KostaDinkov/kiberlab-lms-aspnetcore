using System.Collections.Generic;
using KiberlabLMS.Data.Common.Models;

namespace KiberlabLMS.Data.Models.State
{
    public class CourseState : BaseModel
    {
        public CourseState()
        {
            this.SectionStates = new HashSet<SectionState>();
        }

        public string CourseInstanceId { get; set; }

        public CourseInstance CourseInstance { get; set; }

        public ICollection<SectionState> SectionStates { get; set; }
    }
}
