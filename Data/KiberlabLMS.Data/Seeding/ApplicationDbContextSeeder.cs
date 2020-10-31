using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace KiberlabLMS.Data.Seeding
{
    public class ApplicationDbContextSeeder : ISeeder
    {
        public void Seed(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }

            if (serviceProvider == null)
            {
                throw new ArgumentNullException(nameof(serviceProvider));
            }

            var logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger(typeof(ApplicationDbContextSeeder));

            var seeders = new List<ISeeder>
                          {
                              new RolesSeeder(),
                              new SettingsSeeder(),
                              new CourseSeeder(),
                              new UserSeeder(),
                              new EnrollmentSeeder(),
                          };

            foreach (var seeder in seeders)
            {
                seeder.Seed(dbContext, serviceProvider);
                dbContext.SaveChanges();
                logger.LogInformation($"Seeder {seeder.GetType().Name} done.");
            }
        }
    }
}
