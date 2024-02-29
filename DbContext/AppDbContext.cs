using Microsoft.EntityFrameworkCore;
using Trail.Models;

namespace Trail.DbContexts;

public class AppDbContext:DbContext
{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<users> users { get; set; }
	public DbSet<Address> Address { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
}
