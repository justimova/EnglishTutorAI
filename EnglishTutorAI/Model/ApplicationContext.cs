using EnglishTutorAI.Model;
using Microsoft.EntityFrameworkCore;

internal class ApplicationContext : DbContext
{
	public DbSet<User> Users { get; set; } = null!;

	public ApplicationContext(DbContextOptions<ApplicationContext> options)
			: base(options) {
		//Database.EnsureDeleted();
		//Database.EnsureCreated();
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder) {
		modelBuilder.Entity<User>().HasData(
			new User { UserName = "SuperAdmin", Email = "SuperAdmin@gmail.com" }
		);
	}
}
