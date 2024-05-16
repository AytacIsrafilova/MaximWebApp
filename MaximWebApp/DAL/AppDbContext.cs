using MaximWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MaximWebApp.DAL
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions options) : base(options)
		{
		}
		public DbSet<Slider> Sliders { get; set; }
		public DbSet<Servicee> Servicees { get; set; }
	}
}
