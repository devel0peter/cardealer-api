using cardealer.Models;
using Microsoft.EntityFrameworkCore;

namespace cardealer.Persistence
{
	public class CardealerDbContext : DbContext
	{
		public CardealerDbContext(DbContextOptions<CardealerDbContext> options)
		  : base(options)
		{
		}

		public DbSet<Make> Makes { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<Vehicle> Vehicles { get; set; }
	}
}
