using System;
namespace TBSMobile.Models
{
	public class RaceShortcut
	{
		public int eventId { get; set; }
		public string venue { get; set; }
		public int raceNo { get; set; }
		public DateTime advertisedStartTime { get; set; }
		public int eventType { get; set; }
		public string masterCategoryName { get; set; }
	}

	public class Next5Race
	{
		public RaceShortcut race { get; set; }
		public string timeToJump { get; set; }
		public string eventType { get; set; }
		public int secondsToJump { get; set; }
		public string advertisedStartTime { get; set; }
		public int nextRefresh { get; set; }
	}

	public class PopularMarketLink
	{
		public int eventId { get; set; }
		public int masterEventId { get; set; }
		public int categoryId { get; set; }
		public int masterCategoryId { get; set; }
		public string popularMarketName { get; set; }
		public int eventTypeId { get; set; }
		public string masterEventName { get; set; }
		public string categoryName { get; set; }
		public string eventType { get; set; }
		public string masterCategoryName { get; set; }
		public string venue { get; set; }
		public int raceNumber { get; set; }
		public string mode { get; set; }
		public string eventTypeIco { get; set; }
	}

}
