using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjGara.Models
{
    public class CarInfo
    {
        public int CarId { get; set; }
        public string CarCode { get; set; }
        public string CarName { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string CarOwner { get; set; }
        public DateTime CarTime { get; set; }

    }
}
