using AutoMapper;
using cardealer.Models;
using cardealer.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cardealer.Controllers
{
	public class FeatureController : Controller
	{
		private readonly CardealerDbContext _context;
		private readonly IMapper _mapper;

		public FeatureController(CardealerDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		[HttpGet("/api/features")]
		public async Task<IEnumerable<FeatureResource>> GetFeaturesAsync()
		{
			var features = await _context.Features.ToListAsync().ConfigureAwait(false);

			return _mapper.Map<List<Feature>, List<FeatureResource>>(features);
		}
	}
}
