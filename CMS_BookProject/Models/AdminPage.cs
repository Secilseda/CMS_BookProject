using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_BookProject.Models
{
	[Table("AdminPage")]
	public class AdminPage
	{
		[Required]
		public string Name { get; set; }
		public int Password { get; set; }
		public virtual Book Book { get; set; }
	}
}
