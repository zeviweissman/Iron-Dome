using iron_dome.Models;
using Microsoft.EntityFrameworkCore;

namespace iron_dome.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration) : DbContext(options)
    {
        private readonly IConfiguration _configuration = configuration;

        public DbSet<ThreatModel> Threats { get; set; }
       public DbSet<AdminModel> Admin { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
