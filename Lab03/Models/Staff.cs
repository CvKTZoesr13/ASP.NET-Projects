
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab03.Models
{
	public class Staff
	{
		public int StaffID { get; set; }
		public string StaffName { get;set; }
		public DateTime BirthOfDate { get; set; }
		public decimal Salary { get; set; }
		public string StaffImage { get; set; }


		public Staff() { }
		public Staff(int staffID, string staffName, DateTime birthOfDate, decimal salary, string staffImage)
		{
			StaffID=staffID;
			StaffName=staffName;
			BirthOfDate=birthOfDate;
			Salary=salary;
			StaffImage=staffImage;
		}	
	}
}