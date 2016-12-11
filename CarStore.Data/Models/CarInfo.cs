using CarStore.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarStore.Data.Models
{
    [Table("CarInfo")]
    public class CarInfo
    {
        public int Id { get; set; }
        public BodyType BodyType { get; set; }
        public EngineType EngineType { get; set; }
        public DrivetrainType DrivetrainType { get; set; }
        public GearboxType GearBoxType { get; set; }
        public int ProductionYear { get; set; }
        public int EngineCapacity { get; set; }
        public int EnginePower { get; set; }
        public int Mileage { get; set; }
        public bool Damaged { get; set; }
        public bool Registered { get; set; }
        public int Doors { get; set; }
        public int Seats { get; set; }
        public decimal Price { get; set; }
        public virtual Car Car { get; set; }
        public virtual ICollection<CarEquipment> Equipment { get; set; }
        public virtual ICollection<CarImage> Images { get; set; }
    }
}
