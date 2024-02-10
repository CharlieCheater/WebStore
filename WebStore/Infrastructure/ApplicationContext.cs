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
			Database.EnsureCreated();
		}
		public DbSet<Client> Clients { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderProduct> OrderProducts { get; set; }
		public DbSet<Product> Products { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<OrderProduct>(x =>
			{
				x.HasKey(x => new { x.ProductId, x.OrderId });
				x.HasOne(c => c.Product).WithMany(c => c.Orders);
				x.HasOne(c => c.Order).WithMany(c => c.Products);
			});
			modelBuilder.Entity<Client>().HasData(new List<Client>()
			{
				new() { Id = 1, Name = "Тестовый клиент" },
			});
			modelBuilder.Entity<Product>().HasData(new List<Product>()
			{
				new() { Id = 1, Name = "Тестовый продукт", Amount = 1, IsActive = true, Description = "Описание", Price = 549 },
			});
			modelBuilder.Entity<Order>().HasData(new List<Order>()
			{
				new() { Id = 1, ClientId = 1 },
			});
			modelBuilder.Entity<OrderProduct>().HasData(new List<OrderProduct>()
			{
				new() { OrderId = 1, ProductId = 1, Amount = 2, Price = 400 },
			});
		}
	}
}
