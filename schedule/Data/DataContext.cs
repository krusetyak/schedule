using System;
using Microsoft.EntityFrameworkCore;
using schedule.Model;

namespace schedule.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }

        public DbSet<Work> Works { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Sort> Sorts { get; set; }

        public DbSet<Patron> Patrons { get; set; }
    }
}
