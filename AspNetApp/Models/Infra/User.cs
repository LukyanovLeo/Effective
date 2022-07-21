using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetApp.Models.Infra
{
	public class User
	{
		[Required]
		public string Login { get; set; }

		[Required]
		public string Password { get; set; }

		public Role Role { get; set; }
	}

	public enum Role
	{
		Admin,
		User
	}
}