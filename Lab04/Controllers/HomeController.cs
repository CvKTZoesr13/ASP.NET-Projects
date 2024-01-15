using Lab04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab04.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult Details ()
		{
			Employee employee = new Employee("001", "Ayaka Kamisato", "Female", "Inazuma", "frezee", "Kamisato Area", true);
			ViewData["EmployeeData"] = employee;
			return View();
		}
	}
}