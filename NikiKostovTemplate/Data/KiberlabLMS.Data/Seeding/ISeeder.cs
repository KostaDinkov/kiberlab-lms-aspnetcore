using System;

namespace KiberlabLMS.Data.Seeding
{
    public interface ISeeder
    {
        void Seed(ApplicationDbContext dbContext, IServiceProvider serviceProvider);
    }
}
