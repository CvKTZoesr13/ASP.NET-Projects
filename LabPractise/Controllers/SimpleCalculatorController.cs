using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabPractise.Controllers
{
    public class SimpleCalculatorController : Controller
    {
        // GET: SimpleCalculator
        public ActionResult Index()
        {
            return View();
        }
		[HttpPost]
		public ActionResult Sum()
		{
			int a = int.Parse(Request["inputA"]);
			int b = int.Parse(Request["inputB"]);
			int result = a+ b;
			ViewBag.result = result;
			return View("Index");
		}
		[HttpPost]
		public ActionResult Minus()
		{
			int a = int.Parse(Request["inputA"]);
			int b = int.Parse(Request["inputB"]);
			int result = a - b;
			ViewBag.result = result;
			return View("Index");
		}
		[HttpPost]
		public ActionResult Multi()
		{
			int a = int.Parse(Request["inputA"]);
			int b = int.Parse(Request["inputB"]);
			int result = a * b;
			ViewBag.result = result;
			return View("Index");
		}
		[HttpPost]
		public ActionResult Devide()
		{
			int a = int.Parse(Request["inputA"]);
			int b = int.Parse(Request["inputB"]);
			double result = (double)a / b;
			ViewBag.result = result;
			return View("Index");
		}
	}
}