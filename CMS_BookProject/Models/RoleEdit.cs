using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_BookProject.Models
{
	public class RoleEdit
	{
		public IdentityRole Role { get; set; }//Hazır yapı olan Identity'nin sunduğu rol.
		public IEnumerable<AppUser> Members { get; set; }
		public IEnumerable<AppUser> NonMembers { get; set; }
		public string RoleName { get; set; }
		public string[] AddIds { get; set; }
		public string[] DeleteIds { get; set; }
	}
}
