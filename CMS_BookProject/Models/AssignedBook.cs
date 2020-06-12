using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_BookProject.Models
{
	[Table("AssignedBooks")]
	public class AssignedBook:BaseEntity
	{
		public int BookId { get; set; }
		public virtual Book Book { get; set; }

		public int AppUserId { get; set; }
		public virtual AppUser AppUser { get; set; }
	}
}
