using System;

namespace cardealer.Controllers.Resources
{
	public class VehicleResource
	{
		public int Id { get; set; }
		public string ContactName { get; set; }
		public string ContactPhone { get; set; }
		public ModelResource Model { get; set; }
		public DateTime LastUpdated { get; set; }
	}
}
