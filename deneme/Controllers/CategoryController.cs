using BusinnessLayer.Concrete;
using DataAccesesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace deneme.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values= cm.GetAllCategories();
            return View(values);
        }
    }
}
