using ETrade.UI.Models.ViewModel;
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class CategoriesController : BaseController
    {

        private readonly CategoriesModel model;

        public CategoriesController(IUow uow, CategoriesModel model) : base(uow)
        {

            this.model = model;
        }

        public IActionResult List()
        {
            return View(Uow.catRepos.GetCategories());
        }
        public IActionResult Create()
        {
            model.Text = "Save";
            model.Head = "New Categories";
            model.Class = "btn btn-outline-success my-2";

            return View("Crud", model);
        }
        [HttpPost]
        public IActionResult Create(CategoriesModel model)
        {
            
            Uow.catRepos.Add(model.Categories);
            Uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Update(Guid Id)
        {
            model.Text = "Save";
            model.Head = "Update Categories";
            model.Class = "btn btn-outline-success my-2";
            model.Categories = Uow.catRepos.Find(Id);

            return View("Crud", model);
        }
        [HttpPost]
        public IActionResult Update(CategoriesModel model)
        {

            Uow.catRepos.Update(model.Categories);
            Uow.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Delete(Guid Id)
        {

            Uow.catRepos.Delete(Uow.catRepos.Find(Id));
            Uow.Commit();
            return RedirectToAction("List");
        }
        
    }
}
