using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;

using WebStore.Infrastructure.Models;

namespace WebStore.Infrastructure
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options)
			:base(options) 
		{ 
			Database.EnsureDeleted();
			Database.EnsureCreated();
		}
		public DbSet<Pacient> Pacients { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
		}
	}
}
