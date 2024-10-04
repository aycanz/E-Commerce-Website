using BusinnessLayer.Concrete;
using DataAccesesLayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace deneme.Controllers
{
    public class RegisterController : Controller
    {

        CustomerManager cm = new CustomerManager(new EfCustomerRepository() );


        [HttpGet]    
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index( Tbl_Customer p)
        {
          cm.CustomerAdd(p);

            return RedirectToAction("Index","Product");

                }








    }
}
