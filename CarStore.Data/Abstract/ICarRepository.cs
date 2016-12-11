using CarStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Data.Abstract
{
    public interface ICarRepository
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Advertisment> Advertisments { get; }
        IEnumerable<CarEquipment> Equipment { get; }
        IEnumerable<CarBrand> Brands { get; }
        IEnumerable<CarInfo> CarInfos { get; }

        void SaveCar(Car car);
        Car RemoveCar(Car car);
        void SaveAdvertistment(Advertisment ad);
        Advertisment RemoveAdvertisment(Advertisment ad);
        void SaveEquipment(CarEquipment eq);
        CarEquipment RemoveEquipment(CarEquipment eq);
        void SaveBrand(CarBrand brand);
        CarBrand RemoveBrand(CarBrand brand);
        void SaveInfo(CarInfo brand);
        CarInfo RemoveInfo(CarInfo brand);
    }

}
