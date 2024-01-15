using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab04.Models
{
	public class Employee
	{
		public string EmpId { get; set; }
		public string Name { get; set; }
		public string Gender { get; set; }
		public string City { get; set; }
		public string Skills { get; set; }
		public string Address { get; set; }
		public bool AgreeTerm
		{
			get
			{
				return true;
			}
			set { }
		}

		//constructors
		public Employee() { }
		public Employee(string empId, string name, string gender, string city, string skills, string address, bool agreeTerm)
		{
			EmpId=empId;
			Name=name;
			Gender=gender;
			City=city;
			Skills=skills;
			Address=address;
			AgreeTerm=agreeTerm;
		}

	}
}