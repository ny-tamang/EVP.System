using EVP.System.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EVP.System.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<BusinessVisa> BusinessVisas { get; set; }
        public DbSet<PassportInfo> PassportInfos { get; set; }
        public DbSet<StudentVisa> StudentVisas { get; set;}
        public DbSet<TouristVisa> TouristVisas { get; set; }

    }
}