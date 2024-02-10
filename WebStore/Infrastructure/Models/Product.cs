using System.Collections.Generic;

namespace WebStore.Infrastructure.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public int Amount { get; set; }
		public bool IsActive { get; set; }
		public List<OrderProduct> Orders { get; set; } = new();
	}
}
