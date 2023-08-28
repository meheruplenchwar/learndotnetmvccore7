using Microsoft.AspNetCore.Mvc;
using ST_Proj_DotNetCoreMVC.Models;

namespace ST_Proj_DotNetCoreMVC.Controllers
{
    public class PersonController : Controller
    {
        //Get Method
        public IActionResult Index()
        {
            ////Passing data from controller to View
            //    //Use to pass data from controller to view
            //        ViewBag.Data = "This is ViewBag";
            //        ViewData["Data2"] = "This is ViewData";

            //    //Use to pass data from one controller method to another controller method
            //        TempData["Data3"] = "This is TempData";
            ViewBag.Title = "Index Page";
                    return View();
        }

        [HttpPost]
        public IActionResult AddPerson(PersonModel person)
        {
            ViewBag.Title = "Add Person";
            return View();
        }

        public IActionResult AddPerson()
        {
            ViewBag.Title = "Add Person";
            return View();
        }
    }
}
