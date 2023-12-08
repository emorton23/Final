using System;
using Microsoft.EntityFrameworkCore;

namespace Final.Models
{
    public class FinalContext : DbContext
    {
        public FinalContext (DbContextOptions<FinalContext> options)
			: base(options)
		{
		}
        
        public DbSet<Game> Games {get; set;} = null!;
        public DbSet<User> Users {get; set;} = null!;
    }
}