using System;
using UnitOfWork.Demo.DataModels;

namespace UnitOfWork.Demo
{
	public class WidgetRepository : IWidgetRepository
	{
		private DomainDbContext _dbContext;

		public WidgetRepository(DomainDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		//6. Create Widget.
		public void CreateWidget(Widget widget)
		{
			//This will add the new widget to the DbContext but not save it to the context yet.
			_dbContext.Widget.Add(widget);
		}
	}
}

