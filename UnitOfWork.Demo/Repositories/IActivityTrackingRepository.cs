using UnitOfWork.Demo.DataModels;

namespace UnitOfWork.Demo
{
    public interface IActivityTrackingRepository
    {
        void CreateActivityTrackingRecord(ActivityTracking activityTracking);
    }
}