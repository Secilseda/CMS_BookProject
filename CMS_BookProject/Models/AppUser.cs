using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_BookProject.Models
{
	public class AppUser:IdentityUser
	{
		//AppUser sınıfımızı IdentityUser ile extend ettiğimizde, kalıtım vasıtasıyla IdentityUser'ın yetenek ve özelliklerini elde etmiş oluruz. Lakin IdentityUser'ın içermediği özellikleri kendimiz ekleyebiliriz.
	}
}
