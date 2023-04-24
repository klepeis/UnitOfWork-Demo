using System;
namespace UnitOfWork.Demo.DataModels
{
	public class ActivityTracking
	{
		public long Id { get; set; }
		public string OriginalValue { get; set; }
		public string NewValue { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime ModifiedDate { get; set; }

		public ActivityTracking()
		{
		}
	}
}

