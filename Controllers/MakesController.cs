using AutoMapper;
using cardealer.Models;
using cardealer.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace cardealer.Controllers
{
	public class MakesController : Controller
	{
		private readonly CardealerDbContext _context;
		private readonly IMapper _mapper;

		public MakesController(CardealerDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		[HttpGet("/api/makes")]
		public async Task<IEnumerable<MakeResource>> GetMakesAsync()
		{
			var makes = await _context.Makes.Include(m => m.Models).ToListAsync().ConfigureAwait(false);

			return _mapper.Map<List<Make>, List<MakeResource>>(makes);
		}

		// GET api/<controller>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<controller>
		[HttpPost]
		public void Post([FromBody]string value)
		{
		}

		// PUT api/<controller>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/<controller>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
