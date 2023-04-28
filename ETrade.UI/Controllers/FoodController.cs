using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
	public class FoodController : Controller
	{
		public IActionResult List()
		{
			return View();
		}
	}
}
