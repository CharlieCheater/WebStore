using System.Collections.Generic;

namespace WebStore.Infrastructure.Models
{
	public class Client
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public List<Order> Orders { get; set; }
	}
}
