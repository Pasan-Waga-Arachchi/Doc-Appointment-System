using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD_Project.BasicClasses
{
    class Payment
    {
        public string Bill_Id { get; set; }
        public double Amount { get;set; }

        public string PaymentStatus { get; set; }
        public string PatientId { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
