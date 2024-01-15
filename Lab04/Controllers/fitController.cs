using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab04.Controllers
{
    public class fitController : Controller
    {
        // GET: fit
        public ActionResult Index()
        {
            return View();
        }
		public ActionResult Kythuat()
		{
			return View();
		}
		public ActionResult Hethong()
		{
			return View();
		}
	}
}