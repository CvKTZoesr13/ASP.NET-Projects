using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab03.Controllers
{
    public class UploadFileController : Controller
    {
        // GET: UploadFile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UploadFile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file) 
        {
            try
            {
                if(file.ContentLength> 0)
                {
                    string _FileName = Path.GetFileName(file.FileName);
                    string _Path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);
                    file.SaveAs(_Path);
                }
                ViewBag.Message = "File is uploaded successfully!";
                return View();
            }catch(Exception ex)
            {
                ViewBag.Message = "Unsuccessfully! Something went wrong!" + ex.Message;
                return View();
            }
        }
    }
}