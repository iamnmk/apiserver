using Microsoft.EntityFrameworkCore;
using Codepulse.API.Models.Domain;
using System;
namespace Codepulse.API.Data
{
	public class ApplicationDbContext :DbContext
	{
		public ApplicationDbContext(DbContextOptions options): base(options)
		{

		}

		public DbSet<BlogPost> BlogPosts  { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

