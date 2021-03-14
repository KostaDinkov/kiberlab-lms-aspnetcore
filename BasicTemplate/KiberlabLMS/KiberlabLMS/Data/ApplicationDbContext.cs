using System;

using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KiberlabLMS.Models.CourseModels;
using KiberlabLMS.Models.Shared;
using KiberlabLMS.Models.State;
using KiberlabLMS.Models.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using KiberlabLMS.ViewModels.Lesson;
using KiberlabLMS.ViewModels.Sections;

namespace KiberlabLMS.Data
{
    public class ApplicationDbContext : IdentityDbContext <ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Section>()
                .Property(s => s.SectionType)
                .HasConversion<string>();
                //    t => t.ToString(),
                //    t => (SectionType) Enum.Parse(typeof(SectionType), t)
                //);
        }

        public override int SaveChanges() => this.SaveChanges(true);

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
            this.SaveChangesAsync(true, cancellationToken);

        public override Task<int> SaveChangesAsync(
            bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = default)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
        private void ApplyAuditInfoRules()
        {
            var changedEntries = this.ChangeTracker
                .Entries()
                .Where(e =>
                    e.Entity is IAuditInfo &&
                    (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in changedEntries)
            {
                var entity = (IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default)
                {
                    entity.CreatedOn = DateTime.UtcNow;
                }
                else
                {
                    entity.ModifiedOn = DateTime.UtcNow;
                }
            }
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<VideoSection> VideoSections { get; set; }

        public DbSet<LabSection> LabSections { get; set; }

        public DbSet<TextSection> TextSections { get; set; }

        public DbSet<QuizSection> QuizSections { get; set; }

        public DbSet<CourseState> CourseStates { get; set; }

        public DbSet<SectionState> SectionStates { get; set; }

        public DbSet<CourseInstance> CourseInstances { get; set; }

        public DbSet<UserProgress> UserProgresses { get; set; }

        public DbSet<KiberlabLMS.ViewModels.Lesson.LessonViewModel> LessonViewModel { get; set; }

        public DbSet<KiberlabLMS.ViewModels.Sections.VideoSectionViewModel> VideoSectionViewModel { get; set; }

        public DbSet<KiberlabLMS.Models.CourseModels.Section> Section { get; set; }
    }
}
