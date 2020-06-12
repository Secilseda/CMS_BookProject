﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_BookProject.Models
{
	public class UserEdit
	{
		[Required, EmailAddress]
		public string Email { get; set; }
		[Required, DataType(DataType.Password), MinLength(4, ErrorMessage = "Minimum lenght is 4")]
		public string Password { get; set; }

		public UserEdit() { }
		public UserEdit(AppUser appUser)//AppUser'ın kendisi gelecek.
		{
			Email = appUser.Email;
			Password = appUser.PasswordHash;
		}
	}
}
