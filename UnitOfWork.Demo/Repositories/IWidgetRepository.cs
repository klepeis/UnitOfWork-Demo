using UnitOfWork.Demo.DataModels;

namespace UnitOfWork.Demo
{
    public interface IWidgetRepository
    {
        void CreateWidget(Widget widget);
    }
}