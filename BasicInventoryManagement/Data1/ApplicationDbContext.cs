using Microsoft.EntityFrameworkCore;
using BusinessLogicLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary.Data1
{
    public class AmbientHouseDbContext : DbContext
    {
        public AmbientHouseDbContext(DbContextOptions<AmbientHouseDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=w230092_AmbientHouse;Trusted_Connection=True;");
        }
        public DbSet<Ratio> Ratios { get; set; }
    }
}
