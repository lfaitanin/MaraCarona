using MaraCarona.Models;
using Microsoft.EntityFrameworkCore;

namespace MaraCarona.Context
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }

        public DbSet<Club> Clubs { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

    }
}
