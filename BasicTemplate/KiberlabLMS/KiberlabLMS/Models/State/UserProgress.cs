using System.Collections.Generic;
using KiberlabLMS.Models.User;

namespace KiberlabLMS.Models.State
{
    public class UserProgress : BaseModel
    {
        public UserProgress()
        {
            this.CourseStates = new HashSet<CourseState>();
        }
        

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public ICollection<CourseState> CourseStates { get; set; }
    }
}
