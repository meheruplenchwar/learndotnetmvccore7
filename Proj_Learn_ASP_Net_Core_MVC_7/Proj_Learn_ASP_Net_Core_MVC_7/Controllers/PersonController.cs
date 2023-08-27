using Microsoft.AspNetCore.Mvc;

namespace Proj_Learn_ASP_Net_Core_MVC_7.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            //Passing data from View to Controller
            //Note - We are not using these things in real world scenario,
            //it's declared as a bad practice because it uses session to store data and it's a burden for server

            //ViewBag and ViewData used to pass the data from controller to view
            ViewBag.Data1 = "This is ViewBag";
                    ViewData["Data2"] = "This is ViewData";

                //Using TempData we can also pass data from one controller method to another controller method
                TempData["Data3"] = "This is TempData";
                return View();
        }
    }
}
