using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapTaxi.Core;

namespace TapTaxi
{
    public class Controller
    {
        private static Repository repository = new Repository();

        public static void Update(Taxist taxist)
        {
            if (taxist.Id == 0)
                repository.Taxists.Add(taxist);
            repository.SaveChanges();
        }

        public static List<Taxist> Taxists
        {
            get
            {
                return repository.Taxists.ToList();
            }
        }

        public static void Remove(Taxist taxist)
        {
            repository.Taxists.Remove(taxist);
            repository.SaveChanges();
        }

        public static void Update(Client client)
        {
            if (client.Id == 0)
                repository.Clients.Add(client);
            repository.SaveChanges();
        }

        public static List<Client> Clients
        {
            get
            {
                return repository.Clients.ToList();
            }
        }

        public static void Remove(Client client)
        {
            repository.Clients.Remove(client);
            repository.SaveChanges();
        }

        public static void Update(ModelCar modelCar)
        {
            if (modelCar.Id == 0)
                repository.ModelCars.Add(modelCar);
            repository.SaveChanges();
        }

        public static List<ModelCar> ModelCars
        {
            get
            {
                return repository.ModelCars.ToList();
            }
        }

        public static void Remove(ModelCar modelCar)
        {
            repository.ModelCars.Remove(modelCar);
            repository.SaveChanges();
        }
        public static void Update(Order order)
        {
            if (order.Id == 0)
                repository.Orders.Add(order);
            repository.SaveChanges();
        }

        public static List<Order> Orders
        {
            get
            {
                return repository.Orders.ToList();
            }
        }

        public static void Remove(Order order)
        {
            repository.Orders.Remove(order);
            repository.SaveChanges();
        }

        public static List<Person> People
        {
            get
            {
                return repository.Persons.ToList();
            }
        }

        public static void SaveChanges()
        {
            repository.SaveChanges();
        }

        public static List<Manager> Managers
        {
            get
            {
                return repository.Managers.ToList();
            }
        }

        public static void Remove(Manager manager)
        {
            repository.Managers.Remove(manager);
            repository.SaveChanges();
        }

        public static void Update(Manager manager)
        {
            if (manager.Id == 0)
                repository.Managers.Add(manager);
            repository.SaveChanges();
        }
    }
}
