using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab03.Models
{
	public class SinhVien
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public double Mark { get; set; }

		public SinhVien() { }
		public SinhVien(string id, string name, double mark) {
			this.Id = id;
			this.Name = name;
			this.Mark = mark;
		}
	}
}