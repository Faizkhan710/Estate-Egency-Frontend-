using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserRegistrationController : Controller
    {
        RealStateEntities db = new RealStateEntities();
        // GET: UserRegistration
        public ActionResult SignUp()
        {


            return View();
        }
        [HttpPost]
        public ActionResult SignUp(userTable ut)
        {
            if (ModelState.IsValid)
            {
                var checkemail = db.userTable.Where(a => a.Email == ut.Email).FirstOrDefault();
                if(checkemail == null)
                {
                    db.userTable.Add(ut);
                    db.SaveChanges();
                    ModelState.Clear();
                    return RedirectToAction("Login");
                }
                else
                {
                    ViewBag.email = "Email is already registered";
                }
            }
            return View();
        }

        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(userTable ut)
        {
            var LoginLogic = db.userTable.Where(a => a.Email == ut.Email && a.Password == ut.Password).FirstOrDefault();
            if(LoginLogic != null)
            {
                if (LoginLogic.Status == "Buyer")
                {
                    return RedirectToAction("Index", "Visitor");
                }
                else if(LoginLogic.Status == "Seller")
                {
                    return RedirectToAction("Index", "Dashboard");
                }
            }
            else
            {
                ViewBag.logfailed = "Invalid Credientials";
            }


            return View();
        }
    }
}