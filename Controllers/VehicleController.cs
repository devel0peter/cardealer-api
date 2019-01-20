using AutoMapper;
using cardealer.Controllers.Resources;
using cardealer.Models;
using cardealer.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cardealer.Controllers
{
	public class VehicleController : Controller
	{
		private readonly CardealerDbContext _context;
		private readonly IMapper _mapper;

		public VehicleController(CardealerDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		[HttpGet("api/vehicles")]
		public async Task<IEnumerable<VehicleResource>> GetVehiclesAsync()
		{
			var vehicles = await _context.Vehicles.Include(vehicle => vehicle.Model).ToListAsync().ConfigureAwait(false);

			return _mapper.Map<List<Vehicle>, List<VehicleResource>>(vehicles);
		}
	}
}