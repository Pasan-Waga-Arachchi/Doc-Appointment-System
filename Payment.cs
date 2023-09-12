using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD_Project
{
    class Payment
    {
        public int PaymentId { get; set; }
        public int Amount { get;set; }
        public string PatientId { get; set; }
        public String PaymentMethod { get; set; }
        public String PaymentState { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
