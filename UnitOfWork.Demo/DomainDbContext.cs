using System;
using Microsoft.EntityFrameworkCore;
using UnitOfWork.Demo.DataModels;

namespace UnitOfWork.Demo
{
	public class DomainDbContext : DbContext
	{
		public DbSet<ActivityTracking> ActivityTracking { get; set; }
		public DbSet<Widget> Widget { get; set; }

		public DomainDbContext()
		{
		}
	}
}

