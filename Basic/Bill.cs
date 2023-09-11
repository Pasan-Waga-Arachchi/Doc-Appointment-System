using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD_Project.BasicClasses
{
    class Bill
    {
        public int Bill_Id { get; set; }
        public int Amount { get;set; }

        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public DateTime Date { get; set; }
    }
}
