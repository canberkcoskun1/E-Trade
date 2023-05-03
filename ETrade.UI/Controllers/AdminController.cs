using ETrade.UI.Models.ViewModel;
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
	public class AdminController : BaseController
	{
		private readonly FoodsModel model;

		public AdminController(IUow uow, FoodsModel model) : base(uow)
		{
			this.model = model;
		}

		public IActionResult Admin()
		{
			return View();
		}

		//public IActionResult List()
		//{
		//	//return View(Uow.foodRepos.GetFoods());
		//}


	}
}
