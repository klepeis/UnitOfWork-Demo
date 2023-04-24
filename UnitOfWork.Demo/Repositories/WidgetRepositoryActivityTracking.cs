using System;
using UnitOfWork.Demo.DataModels;

namespace UnitOfWork.Demo.Repositories
{
	public class WidgetRepositoryActivityTracking : WidgetRepositoryDecorator
	{
		
		private readonly IActivityTrackingRepository _activityTrackingRepository;

		public WidgetRepositoryActivityTracking(IWidgetRepository widgetRepository, IActivityTrackingRepository activityTrackingRepository)
			:base(widgetRepository)
		{
			_activityTrackingRepository = activityTrackingRepository;
		}

        public override void CreateWidget(Widget widget)
        {
			//5. Enter decorator.  Call base to create widget.
            base.CreateWidget(widget);

			//7. Create activity tracking object.
			ActivityTracking activityTrackingRecord = new ActivityTracking();
			_activityTrackingRepository.CreateActivityTrackingRecord(activityTrackingRecord);
        }
    }
}

