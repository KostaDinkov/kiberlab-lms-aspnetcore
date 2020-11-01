using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KiberlabLMS.Data.Models.User;

namespace KiberlabLMS.Data.Seeding
{
    public class UserSeeder : ISeeder
    {
        public void Seed(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Users.Any())
            {
                return;
            }

            var users = new List<ApplicationUser>
            {
                new ApplicationUser
                {
                    Email = "kosta@softuni.bg", EmailConfirmed = true, IsDeleted = false, LockoutEnabled = false,
                    UserName = "kostadinkov", TwoFactorEnabled = false,
                },
                new ApplicationUser
                {
                    Email = "pesho@softuni.bg", EmailConfirmed = true, IsDeleted = false, LockoutEnabled = false, 
                    UserName = "pesho", TwoFactorEnabled = false,
                },

            };
            var userProfile1 = new UserProfile { ApplicationUser = users[0], ApplicationUserId = users[0].Id, FirstName = "Kosta", LastName = "Dinkov" };
            var userProfile2 = new UserProfile { ApplicationUser = users[1], ApplicationUserId = users[1].Id, FirstName = "Pesho", LastName = "Piponov" };
            dbContext.UserProfiles.AddRange(userProfile1, userProfile2);

        }
    }
}
