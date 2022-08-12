using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PadraoCamadas.Models.Entities;

namespace PadraoCamadas.Context
{
	public class CamadasDbContext : DbContext
	{
		public DbSet<User>? Users { get; set; }

		public CamadasDbContext(DbContextOptions<CamadasDbContext> opt) : base(opt)
		{
		}
	}
}