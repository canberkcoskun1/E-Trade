using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class CategoriesController : BaseController
    {
        public CategoriesController(IUow uow) : base(uow)
        {
        }

        public IActionResult List()
        {
            return View(Uow.catRepos.GetCategories());
        }

    }
}
