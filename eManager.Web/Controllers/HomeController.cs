using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eManager.Domain;

namespace eManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private IEManagerDataSource managerDataSource;

        public HomeController(IEManagerDataSource managerDataSource) {
            this.managerDataSource = managerDataSource;
        }

        public ActionResult Index() {
            var allDepartments = managerDataSource.Departments;

            return View(allDepartments);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
