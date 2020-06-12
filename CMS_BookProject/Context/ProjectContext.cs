using CMS_BookProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_BookProject.Context
{
	public class ProjectContext: DbContext
	{
		public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }

		public DbSet<Category> Categories { get; set; }
		public DbSet<AdminPage> AdminPages { get; set; }
		public DbSet<AssignedBook> AssignedBooks { get; set; }
		public DbSet<Author> Authors { get; set; }
		public DbSet<BAuthors> BAuthors { get; set; }
		public DbSet<Book> Books { get; set; }
	}
}
