using System;
using System.Linq;
using System.Threading.Tasks;
using KiberlabLMS.Data.Models;

namespace KiberlabLMS.Data.Seeding
{
    internal class SettingsSeeder : ISeeder
    {
        public void Seed(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Settings.Any())
            {
                return;
            }

            dbContext.Settings.Add(new Setting { Name = "Setting1", Value = "value1" });
        }
    }
}
