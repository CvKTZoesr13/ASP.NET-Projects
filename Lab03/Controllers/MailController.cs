using Lab03.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Lab03.Controllers
{
	public class MailController : Controller
	{
		// GET: Mail
		public ActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Index(MailInfo mailModel, FormCollection form, HttpPostedFileBase fileUploader)
		{
			string toForm = form["To"];
			try
			{
				using (MailMessage mail = new MailMessage())
				{
					mail.From = new MailAddress(mailModel.From);
					mail.To.Add(mailModel.To);
					mail.Subject = mailModel.Subject;
					mail.Body = mailModel.Body;
					mail.IsBodyHtml = true;
					if (fileUploader.ContentLength > 0)
					{
						string fileName = Path.GetFileName(fileUploader.FileName);
						mail.Attachments.Add(new Attachment(fileUploader.InputStream, fileName));
					}
					using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
					{
						smtp.UseDefaultCredentials = false;
						smtp.Credentials  = new NetworkCredential(mailModel.From, mailModel.Password);
						smtp.EnableSsl = true;
						smtp.Send(mail);
					}
				}
				ViewBag.Message = $"Email has been sent to {toForm} successfully!";
				return RedirectToAction("Index", "Mail");
			}
			catch (Exception ex)
			{
				ViewBag.Message = ex.Message;
				return RedirectToAction("Index", "Mail");
			}
		}
	}
}