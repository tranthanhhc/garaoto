using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjGara.Models
{
    public class BillInfor
    {
        public int BiId { get; set; }
        public string BiCode { get; set; }
        public string BiType { get; set; }
        public string BiOName { get; set; }
        public int? BiPrice { get; set; }
        public int? BiQua { get; set; }
    }
}
