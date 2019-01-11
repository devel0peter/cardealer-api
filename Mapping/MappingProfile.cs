using AutoMapper;
using cardealer.Controllers.Resources;
using cardealer.Models;

namespace cardealer.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Make, MakeResource>();
			CreateMap<Model, ModelResource>();
		}
	}
}
