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

        public ICatRepos catRepos { get; }

        public IOrderDetailRepos orderDetailRepos { get; }

        public IOrderRepos orderRepos { get; }

        public IUserRepos userRepos { get; }

        public IPropertiesRepos propertiesRepos { get; }

        public Uow(Context context, IFoodRepos foodRepos, ICatRepos catRepos, IOrderDetailRepos orderDetailRepos, IOrderRepos orderRepos, IUserRepos userRepos, IPropertiesRepos propertiesRepos)
		{
			this.context = context;
			this.foodRepos = foodRepos;
			this.catRepos = catRepos;
			this.orderDetailRepos = orderDetailRepos;
			this.orderRepos = orderRepos;
			this.userRepos = userRepos;
			this.propertiesRepos = propertiesRepos;

		}

		public void Commit()
		{
			context.SaveChanges();
		}
	}
}
