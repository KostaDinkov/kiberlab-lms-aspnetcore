using System.Threading.Tasks;
using KiberlabLMS.Data.Models.CourseModels;
using Microsoft.EntityFrameworkCore;

namespace KiberlabLMS.Data.Repositories
{
    public class CourseRepository : EfRepository<Course>
    {
        public CourseRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public async Task<Course> ById(string id)
        {
            return await this.DbSet.Include(course => course.Units).FirstOrDefaultAsync(course => course.Id == id);
        }
    }
}
