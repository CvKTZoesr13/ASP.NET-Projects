using Lab03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab03.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(FormCollection form)
        {
            try
            {
				var formImage = Request.Files["myImage"];
				var imagePath = Server.MapPath("~/Images/" + formImage.FileName);
				formImage.SaveAs(imagePath);
				string path = Server.MapPath("~/StaffInfo.txt");
				string[] lines = { form["txtId"], form["txtName"], form["txtDateOfBirth"], form["txtSalary"], formImage.FileName };
				System.IO.File.WriteAllLines(path, lines);
                ViewBag.Message = "Information has been uploaded successfully!";
				return View("Index");
			}
			catch(Exception ex)
            {
                ViewBag.Message = "Oops. Something went wrong :<!" + ex.Message;
                return View("Index");
            }
        }

        [HttpGet]
        public ActionResult Open () {
            // read from server
            string path = Server.MapPath("~/StaffInfo.txt");
            string[ ] info = System.IO.File.ReadAllLines(path);
			Staff s = new Staff
			{
				StaffID = int.Parse(info[0]),
				StaffName = info[1],
				BirthOfDate = DateTime.Parse(info[2]),
				Salary = decimal.Parse(info[3]),
				StaffImage = info[4]
			};
			// switch to view bag
			ViewBag.Id = s.StaffID; ViewBag.Name = s.StaffName; ViewBag.Birthday = s.BirthOfDate.ToString("yyyy-MM-dd");
            ViewBag.Salary = s.Salary; ViewBag.Image = "../../Images/" + s.StaffImage;
            return View("Index");
        }
    }
}