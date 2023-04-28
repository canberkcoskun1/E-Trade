using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
	public class FoodController : Controller
	{
		private readonly IUow uow;

		public FoodController(IUow uow) 
        {
			this.uow = uow;
		}
        public IActionResult List()
		{
			return View(uow.foodRepos.List());
		}
		
	}
}
