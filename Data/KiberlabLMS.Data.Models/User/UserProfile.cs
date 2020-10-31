using System.Collections.Generic;
using KiberlabLMS.Data.Common.Models;
using KiberlabLMS.Data.Models.State;

namespace KiberlabLMS.Data.Models.User
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
