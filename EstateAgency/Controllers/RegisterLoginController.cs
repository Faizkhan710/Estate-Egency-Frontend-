using EstateAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstateAgency.Controllers
{
    public class RegisterLoginController : Controller
    {
        EstateAgencyEntities db = new EstateAgencyEntities();
        // GET: RegisterLogin
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(User us)
        {
            return View();
        }
    }
}