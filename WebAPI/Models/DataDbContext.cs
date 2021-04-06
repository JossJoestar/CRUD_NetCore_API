using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
	public class DataDbContext : DbContext 
	{
		public DataDbContext()
		{

		}
		public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
		{

		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.EnableSensitiveDataLogging();
				optionsBuilder.UseSqlServer(@"data source=DESKTOP-UVETT3C\SQLEXPRESS; Initial Catalog=MyDB; Integrated Security=SSPI;");
				
			}

		}
		public DbSet<PaymentDetail> PaymentDetails { get; set; }
	}
}
