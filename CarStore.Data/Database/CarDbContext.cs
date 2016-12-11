using CarStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Data.Database
{
    public class CarDbContext:DbContext
    {
        public CarDbContext():base("CarDb")
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarBrand> Brands { get; set; }
        public DbSet<CarEquipment> Equipment { get; set; }
        public DbSet<Advertisment> Advertisments { get; set; }
        public DbSet<CarImage> Images { get; set; }
        public DbSet<CarInfo> CarInfos { get; set; }
    }
}
