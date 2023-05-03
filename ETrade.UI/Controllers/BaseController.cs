using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
	public class BaseController : Controller
	{
		public IUow Uow;

		public BaseController(IUow uow)
        {
			Uow = uow;
		}
    }
}
