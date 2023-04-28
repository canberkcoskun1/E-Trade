using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Ent
{
	public class Orders : Base
	{
		public Guid UserId { get; set; }
		public Guid ShippingAddressId { get; set; }
		public Guid OrderDetailsId { get; set; }
		public decimal TotalPrice { get; set; }
		public bool isDelivered { get; set; }
	}
}
