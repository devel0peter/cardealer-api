using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace cardealer.Models
{
	public class Make
	{
		public int Id { get; set; }

		[Required]
		[StringLength(255)]
		public string Name { get; set; }

		public ICollection<Model> Models { get; set; }
	}
}