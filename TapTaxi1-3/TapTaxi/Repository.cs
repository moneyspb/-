using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapTaxi.Core;

namespace TapTaxi
{
    public class Repository : DbContext
    {
        public Repository() : base("DBConnection")
        {

        }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Manager> Managers { get; set; }
        public DbSet<ModelCar> ModelCars { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<Taxist> Taxists { get; set; }

        public DbSet<Client> Clients { get; set; }
    }
}
