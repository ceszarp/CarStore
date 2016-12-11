using System.ComponentModel.DataAnnotations.Schema;

namespace CarStore.Data.Models
{
    [Table("Equipment")]
    public class CarEquipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
