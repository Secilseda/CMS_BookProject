using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_BookProject.Models
{
	[Table("Books")]
	public class Book:BaseEntity
	{
        [Required, MinLength(3)]
        public string Title { get; set; }
        [Required, MaxLength(256)]
        public string Content { get; set; }
        public string ISNB_No { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual BAuthors BookAuthors { get; set; }
    }
}
