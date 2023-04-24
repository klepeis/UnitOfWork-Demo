using System;
using UnitOfWork.Demo.DataModels;

namespace UnitOfWork.Demo.Repositories
{
	public class WidgetRepositoryDecorator : IWidgetRepository
 	{
        private readonly IWidgetRepository _widgetRepository;

        public WidgetRepositoryDecorator(IWidgetRepository widgetRepository)
		{
            _widgetRepository = widgetRepository;
		}

        public virtual void CreateWidget(Widget widget)
        {
            _widgetRepository.CreateWidget(widget);
        }
    }
}

