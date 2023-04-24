using System;
using UnitOfWork.Demo.DataModels;

namespace UnitOfWork.Demo.Services
{
	public class WidgetCommandService : IWidgetCommandService
	{
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWidgetRepository _widgetRepository;

		public WidgetCommandService(IUnitOfWork unitOfWork, IWidgetRepository widgetRepository)
		{
            _unitOfWork = unitOfWork;
            _widgetRepository = widgetRepository;
		}

        public void CreateWidget(Widget widget)
        {
            //4. Call repository to create "widget"
            _widgetRepository.CreateWidget(widget);

            //9. This method calls the "Save" functionality on the DbContext thus saving all changes being made in the scope of this individual request.
            // So both the new Widget record and the Activity Tracking record that the widget has been created as saved at the same time.  My understanding
            // is that the DbContext.Save method creates a transaction behind the scenes so that if you are saving/updating more than one record it will be done
            // nativately as a transaction.
            _unitOfWork.Commit();
        }
    }
}

