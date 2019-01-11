using cardealer.Controllers.Resources;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace cardealer.Models
{
	public class MakeResource
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public ICollection<ModelResource> Models { get; set; }

		public MakeResource()
		{
			Models = new Collection<ModelResource>();
		}
	}
}
