using System;
namespace UnitOfWork.Demo
{
	public class UnitOfWork : IUnitOfWork
	{
		private DomainDbContext _dbContext;

		public UnitOfWork(DomainDbContext domainDbContext)
		{
			_dbContext = domainDbContext;
		}

		public void Commit()
		{
			_dbContext.SaveChanges();
		}
	}
}

