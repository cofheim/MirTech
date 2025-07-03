using Microsoft.EntityFrameworkCore;
using MirTech.Core.Models;
using System.Reflection;

namespace MirTech.DataAccess
{
    public class MirTechDbContext : DbContext
    {
        public MirTechDbContext(DbContextOptions<MirTechDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
