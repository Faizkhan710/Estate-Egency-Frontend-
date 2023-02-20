using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DashboardController : Controller
    {
        RealStateEntities db = new RealStateEntities();
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult addproperty()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addproperty(property proper)
        {
            if(ModelState.IsValid)
            {
                string myfile = Path
            }
            return View();
        }
    }
}