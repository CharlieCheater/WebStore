using System.Collections.Generic;

namespace WebStore.Infrastructure.Models
{
	public class Order
	{
		public int Id { get; set; }

		public Client Client { get; set; }
		public int ClientId { get; set; }

		public List<OrderProduct> Products { get; set; }
	}
}
