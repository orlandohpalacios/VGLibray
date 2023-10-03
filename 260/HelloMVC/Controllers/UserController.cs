using HelloMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class UserController : Controller
    {
        // This will handle GET requests to /User/Register
        public IActionResult Register()
        {
            var model = new RegisterViewModel();

            //ViewBag.MyHeckinModel = new RegisterViewModel();

            return View(model);
        }

        // We want this one to handle POST requests to /User/Register
        [HttpPost]
        //public IActionResult Register(string username, string email, string password)
        public IActionResult Register(RegisterViewModel model)
        {
            // What values did the user want to register with?
            // The Manual Way of getting the posted values!

            // If we have valid information
            if (model.username == "test" && model.password == "test")
            {
                // Register Successful
                // Send them to the Login Page!
                return Redirect("/User/Login");
            }
            else
            {
                model.ErrorMSg = "Login Failed!";

                //ViewBag.MyHeckinModel = model;

                //ViewBag.MyKey = "MyValue";

                // Register Failed
                return View(model);
            }

            // Add the new User to the database
            // Redirect them to Where?

            // else if we have invalid information

            // Return the user back to the Register View, with error messages
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}