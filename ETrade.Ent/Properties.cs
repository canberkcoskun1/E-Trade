using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Ent
{
	public class Properties : Base
	{
        public string PropertyName { get; set; }
        public decimal Price { get; set; }
        public ICollection<Foods> Foods { get; set; }

    }
}
