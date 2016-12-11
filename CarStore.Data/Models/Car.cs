using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Data.Models
{
    [Table("Car")]
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public int FromYear { get; set; }
        public int ToYear { get; set; }
        public virtual CarBrand Brand { get; set; }

    }
}
