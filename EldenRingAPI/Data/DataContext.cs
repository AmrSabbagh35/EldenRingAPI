using EldenRingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EldenRingAPI.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        // DbSet properties for each model
        public DbSet<Armor> Armors { get; set; }
        public DbSet<Boss> Bosses { get; set; }

        public DbSet<Item> Items { get; set; }
        public DbSet<PlayerClass> PlayerClasses { get; set; }
        public DbSet<Shield> Shields { get; set; }

        public DbSet<Sorcery> Sorceries { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

    }
}
