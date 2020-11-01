using System.Collections.Generic;
using KiberlabLMS.Models.State;

namespace KiberlabLMS.Models.User
{
    public class UserProfile : BaseModel
    {
        public UserProfile()
        {
            this.CourseStates = new HashSet<CourseState>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public ICollection<CourseState> CourseStates { get; set; }
    }
}
