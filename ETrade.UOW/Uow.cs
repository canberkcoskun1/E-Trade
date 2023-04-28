using ETrade.Dal;
using ETrade.Rep.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.UOW
{
	public class Uow : IUow
	{
		private readonly Context context;

		public IFoodRepos foodRepos { get; }
		public Uow(Context context, IFoodRepos foodRepos)
		{
			this.context = context;
			this.foodRepos = foodRepos;
		}

	}
}
