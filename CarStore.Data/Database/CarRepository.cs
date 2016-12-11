using CarStore.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarStore.Data.Models;

namespace CarStore.Data.Database
{
    public class CarRepository : ICarRepository
    {
        private CarDbContext context = new CarDbContext();
        public IEnumerable<Advertisment> Advertisments
        {
            get
            {
                return context.Advertisments;
            }
        }

        public IEnumerable<CarBrand> Brands
        {
            get
            {
                return context.Brands;
            }
        }

        public IEnumerable<Car> Cars
        {
            get
            {
                return context.Cars;
            }
        }

        public IEnumerable<CarEquipment> Equipment
        {
            get
            {
                return context.Equipment;
            }
        }
        public IEnumerable<CarInfo> CarInfos
        {
            get
            {
                return context.CarInfos;
            }
        }

        public Advertisment RemoveAdvertisment(Advertisment ad)
        {
            Advertisment adv = context.Advertisments.Find(ad);
            if (adv != null)
            {
                context.Advertisments.Remove(ad);
                context.SaveChanges();
            }
            return adv;
        }

        public CarBrand RemoveBrand(CarBrand brand)
        {
            CarBrand carBrand = context.Brands.Find(brand);
            if (carBrand != null)
            {
                context.Brands.Remove(carBrand);
                context.SaveChanges();
            }
            return carBrand;
        }

        public Car RemoveCar(Car car)
        {
            Car c = context.Cars.Find(car);
            if (c != null)
            {
                context.Cars.Remove(car);
                context.SaveChanges();
            }
            return c;
        }

        public CarEquipment RemoveEquipment(CarEquipment eq)
        {
            CarEquipment equipment = context.Equipment.Find(eq);
            if (equipment != null)
            {
                context.Equipment.Remove(eq);
                context.SaveChanges();
            }
            return equipment;
        }

        public CarInfo RemoveInfo(CarInfo cInfo)
        {
            CarInfo ci = context.CarInfos.Find(cInfo);
            if (ci != null)
            {
                context.CarInfos.Remove(ci);
                context.SaveChanges();
            }
            return ci;
        }

        public void SaveAdvertistment(Advertisment ad)
        {
            context.Advertisments.Add(ad);
            context.SaveChanges();
        }

        public void SaveBrand(CarBrand brand)
        {
            context.Brands.Add(brand);
            context.SaveChanges();
        }

        public void SaveCar(Car car)
        {
            context.Cars.Add(car);
            context.SaveChanges();
        }

        public void SaveEquipment(CarEquipment eq)
        {
            context.Equipment.Add(eq);
            context.SaveChanges();
        }

        public void SaveInfo(CarInfo cInfo)
        {
            context.CarInfos.Add(cInfo);
            context.SaveChanges();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
