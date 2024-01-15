using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab04.Controllers
{
    public class ListDemoController : Controller
    {
		// GET: ListDemo
		public ActionResult Bullets()
		{
			return View();
		}
		// GET: ListDemo
		public ActionResult Numbering()
		{
			return View();
		}
	}
}