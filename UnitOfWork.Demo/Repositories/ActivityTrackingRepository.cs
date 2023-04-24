using System;
using UnitOfWork.Demo.DataModels;

namespace UnitOfWork.Demo
{
	public class ActivityTrackingRepository : IActivityTrackingRepository
	{
        private DomainDbContext _dbContext;

		public ActivityTrackingRepository(DomainDbContext dbContext)
		{
            _dbContext = dbContext;
		}

        public void CreateActivityTrackingRecord(ActivityTracking activityTracking)
        {
            //8. Add activity tracking record to DbContext.
            _dbContext.ActivityTracking.Add(activityTracking);
        }
    }
}

