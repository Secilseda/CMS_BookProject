using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_BookProject.Models
{
	[Table("Categories")]
	public class Category:BaseEntity
	{
		[Required, MinLength(3)]
		public string Name { get; set; }

		[Required, MaxLength(250)]
		public string Description { get; set; }
		public virtual List<Book> Books { get; set; }
	}
}

