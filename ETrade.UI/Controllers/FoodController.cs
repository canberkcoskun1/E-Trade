using ETrade.DTO;
using ETrade.UI.Models.ViewModel;
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
	public class FoodController : BaseController
	{
		private readonly FoodsModel model; 
		

		public FoodController(IUow uow, FoodsModel model) : base(uow)
		{
			this.model = model;
		}

		
		public IActionResult List()
		{
			return View(Uow.foodRepos.GetFoods());
		}
		public IActionResult Create()
		{
			model.Text = "Save";
			model.Head = "New Foods";
			model.Class = "btn btn-outline-success my-2";
			model.Cats = Uow.catRepos.GetCategories();
			return View("Crud", model);
		}
		[HttpPost]
		public IActionResult Create(FoodsModel model)
		{

			Uow.foodRepos.Add(model.Foods);
			Uow.Commit();
			return RedirectToAction("List");
		}
		public IActionResult Update(Guid Id)
		{
			model.Text = "Save";
			model.Head = "Update Properties";
			model.Class = "btn btn-outline-success my-2";
			model.Foods = Uow.foodRepos.Find(Id);
			model.Cats = Uow.catRepos.GetCategories();

			return View("Crud", model);
		}
		[HttpPost]
		public IActionResult Update(FoodsModel model)
		{

			Uow.foodRepos.Update(model.Foods);
			Uow.Commit();
			return RedirectToAction("List");
		}
		public IActionResult Delete(Guid Id)
		{
			Uow.foodRepos.Delete(Uow.foodRepos.Find(Id));
			Uow.Commit();
			return RedirectToAction("List");
		}
	}
}
