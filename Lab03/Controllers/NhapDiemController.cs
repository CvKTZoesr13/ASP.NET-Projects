using Lab03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab03.Controllers
{
	public class NhapDiemController : Controller
	{
		// GET: NhapDiem
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Save(SinhVien sv)
		{
			// đường dẫn tới file lưu dữ liệu
			string path = Server.MapPath("~/StudentInfo.txt");
			string[] lines = {sv.Id, sv.Name, sv.Mark.ToString()};
			System.IO.File.WriteAllLines(path, lines);
			ViewBag.HanhDong = "Đã ghi từ file!";
			return View("Index");
		}
		public ActionResult Open(SinhVien sv)
		{
			string path = Server.MapPath("~/StudentInfo.txt");
			string[] lines = System.IO.File.ReadAllLines(path);
			sv.Id = lines[0];
			sv.Name = lines[1];
			sv.Mark= double.Parse(lines[2]);
			ViewBag.ThongTin = $"Mã SV: {sv.Id} - Họ tên: {sv.Name} - Điểm: {sv.Mark}";
			ViewBag.HanhDong = "Đã đọc từ file!";
			return View("Index", sv);
		}
	}
}