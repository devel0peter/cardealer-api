using System;
using System.ComponentModel.DataAnnotations;

namespace cardealer.Models
{
	public class Vehicle
	{
		public int Id { get; set; }

		[Required]
		public Model Model { get; set; }

		[Required]
		[StringLength(255)]
		public string ContactName { get; set; }

		[Required]
		[StringLength(255)]
		public string ContactPhone { get; set; }

		public DateTime LastUpdated { get; set; }
	}
}
