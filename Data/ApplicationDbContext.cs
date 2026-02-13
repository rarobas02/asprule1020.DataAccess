using asprule1020.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace asprule1020.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Register> Registers { get; set; }
        public DbSet<PhRegion> PhRegions { get; set; }
        public DbSet<PhProvDist> PhProvDists { get; set; }
        public DbSet<PhCityMun> PhCityMuns { get; set; }
        public DbSet<PhBarangay> PhBarangays { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    }
}
