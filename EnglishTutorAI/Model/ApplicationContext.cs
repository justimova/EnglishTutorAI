using System.Diagnostics.Metrics;
using EnglishTutorAI.Model;
using Microsoft.EntityFrameworkCore;

public class ApplicationContext : DbContext
{
	public DbSet<User> Users { get; set; } = null!;

	public ApplicationContext(DbContextOptions<ApplicationContext> options)
			: base(options) {
		//Database.EnsureDeleted();
		//Database.EnsureCreated();
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder) {
		modelBuilder.Entity<User>().HasData(
			new User { Id = 1, Name = "SuperAdmin", Email = "SuperAdmin@gmail.com", Password = "SuperAdmin" }
		);
	}
}
