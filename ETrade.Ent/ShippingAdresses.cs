using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Ent
{
	public class ShippingAddresses : Base
	{
		public string AddressName { get; set; }
		public string Address { get; set; }
		public Guid UserId { get; set; }
		//[ForeignKey(nameof(UserId))] --> same things
		[ForeignKey("UserId")]
		public Users Users { get; set; }

	}
}
