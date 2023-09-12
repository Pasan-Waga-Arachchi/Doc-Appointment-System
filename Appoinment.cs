using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD_Project
{
    class Appoinment
    {
        public String AppoinmentId { get; set; }
        public String DoctorId { get; set; }
        public String PatientId { get; set; }
        public String AppoinmentStatus { get; set; }
        public DateTime AppoinmentDate { get; set; }
        public DateTime AppoinmentCreatedDate { get; set; }
    }
}
