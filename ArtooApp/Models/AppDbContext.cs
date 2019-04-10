using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Artoo.Models
{
    public class AppDbContext: IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Mistake> Mistakes { get; set; }
        public DbSet<PassionBrand> PassionBrands { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<InspectionMistakeDetail> InspectionMistakeDetails { get; set; }
        public DbSet<EmailRule> EmailRules { get; set; }
        public DbSet<FinalWeek> FinalWeeks { get; set; }
        public DbSet<TechManager> TechManagers { get; set; }
        public DbSet<EmailRuleDetail> EmailRuleDetails { get; set; }

    }
}
