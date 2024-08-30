using CPW219_eCommerceSite.Models;
using Microsoft.EntityFrameworkCore;

namespace CPW219_eCommerceSite.Data
{
    public class VideoGameContext : DbContext
    {
        public VideoGameContext(DbContextOptions<VideoGameContext>options) 
            : base(options) 
        { 

        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Member> Members { get; set; }
    }
}
