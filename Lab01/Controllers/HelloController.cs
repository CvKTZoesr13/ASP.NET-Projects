using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }

        //public string ChaoMung()
        //{
        //    return "<h1>Đây là phương thức chào mừng nằm trong HelloController!</h1>";
        //}
        public string ChaoMung(string ten, int soLan = 0, int id= 3)
        {
            return HttpUtility.HtmlEncode($"Xin chào {ten}. Số lần là: {soLan}\n" + $"Id: {id}");
        }
        public ActionResult MyLink(int? id)
        {
            ViewBag.Message = "Liên kết của tôi!";
            return View();
        }

        public  ActionResult Display()
        {
            //return PartialView("_EmployeeDetail");
            //return new EmptyResult();
            //return Redirect("https://reactjs.org/");
            //return RedirectToAction("Contact", "Home");
            //return Json(new {success = true, username = "vanduc"}, JsonRequestBehavior.AllowGet);
            //return Content("<h1>Hello world! Welcome to our website!</h1>");
            return new FilePathResult(@"D:\Downloads\Documents\1.pdf", "application/pdf");
        }

        public ActionResult EditEmployee(int? id)
        {
            return Content($"Hello employee no. {id}! Welcome to our website!");
        }
    }


}