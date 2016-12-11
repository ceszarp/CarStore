using CarStore.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Data.Models
{
    public class Advertisment
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateExpieres { get; set; }
        public virtual CarInfo CarInfo { get; set; }

    }
}
