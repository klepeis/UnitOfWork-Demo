using System;
namespace UnitOfWork.Demo.DataModels
{
	public class Widget
	{
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Widget()
		{
		}
	}
}

