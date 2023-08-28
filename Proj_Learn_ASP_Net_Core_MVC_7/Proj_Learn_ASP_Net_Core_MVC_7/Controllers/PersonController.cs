using Microsoft.AspNetCore.Mvc;
using Proj_Learn_ASP_Net_Core_MVC_7.Models.Domain;

namespace Proj_Learn_ASP_Net_Core_MVC_7.Controllers
{
    public class PersonController : Controller
    {
        //Use to do connection with Database
        //DatabaseContext is something like HTTPContext, by using which we can do interaction with db
        private readonly DatabaseContext _databaseContext;
        public PersonController(DatabaseContext databaseContext)
        {
                _databaseContext = databaseContext;
        }

        //Get Method
        public IActionResult AddPerson()
        {
            ViewBag.Title = "Add Person Page";
            return View();
        }

        //Post Method
        [HttpPost]
        public IActionResult AddPerson(PersonModel person)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                _databaseContext.Add(person);
                _databaseContext.SaveChanges();
                TempData["ServerMsg"] = "Added Successfully...!!!";
                return RedirectToAction("AddPerson"); //Calling get method
                //return View();
            }
            catch (Exception ex)
            {
                TempData["ServerMsg"] = "Could not added...!!!" + ex;
                return View();
            }
        }
        public IActionResult Index()
        {
            //Passing data from View to Controller
            //Note - We are not using these things in real world scenario,
            //it's declared as a bad practice because it uses session to store data and
            //it's a burden for server

            //ViewBag and ViewData used to pass the data from controller to view
                    ViewBag.Data1 = "This is ViewBag";
                    ViewData["Data2"] = "This is ViewData";
                    ViewBag.Title = "Index Page";

                //Using TempData we can also pass data from
                //one controller method to another controller method
                TempData["Data3"] = "This is TempData";
                return View();
        }
    }
}
