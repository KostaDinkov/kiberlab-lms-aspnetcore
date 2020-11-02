// ReSharper disable VirtualMemberCallInConstructor

using System;
using System.Collections.Generic;
using KiberlabLMS.Models.State;
using Microsoft.AspNetCore.Identity;

namespace KiberlabLMS.Models.User
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
        }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
        
        public DateTime? DeletedOn { get; set; }
        public UserProgress UserProgress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }

        
    }
}
