﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_BookProject.Models
{
	[Table("Book Authors")]
	public class BAuthors:BaseEntity
	{
		[Required, Key]
		public int AuthorId { get; set; }
	}
}
