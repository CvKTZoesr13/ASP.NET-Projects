﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab03.Models
{
	public class MailInfo
	{
		public string From { get; set; }
		public string Password { get; set; }
		public string To { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
	}
}