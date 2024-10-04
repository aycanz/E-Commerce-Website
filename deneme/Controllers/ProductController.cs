using DataAccesesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using BusinnessLayer.Concrete;
using EntityLayer;

namespace deneme.Controllers
{
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());

        
        public IActionResult Index()
        {
            var values = pm.GetProductListWithCategory();
            return View(values);
        }

        public IActionResult ProductDetails(int id)
        {
          
            var values =pm.GetProductWithCategory(id);
            return View(values);
        }

        public IActionResult Shop()
        {

            var values = pm.GetProductListWithCategory();
            return View(values);
        }


        public IActionResult Basket()
        {
            return View();

        }
       

    }
}
