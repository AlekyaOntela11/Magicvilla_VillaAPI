using System;
using Magicvilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Magicvilla_VillaAPI.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
			{
			}
        public DbSet<Villa> Villas { get; set; }
	}
}

