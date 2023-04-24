using System;
using UnitOfWork.Demo.DataModels;

namespace UnitOfWork.Demo.Services
{
	public interface IWidgetCommandService
	{
		public void CreateWidget(Widget widget);
	}
}

