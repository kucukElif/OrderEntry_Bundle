using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderEntry_Bundle.Models;
namespace OrderEntry_Bundle.Controllers
{
    public class LoginController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Login
        public ActionResult LoginPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginPage(User user)
        {
            var userData = db.Users.FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password);
            if (userData != null)
            {
                return RedirectToAction("Index", "Home");

            }
            else
            {
                return View();
            }
         
        }
    }
}