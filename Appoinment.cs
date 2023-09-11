using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD_Project.BasicClasses
{
    class Appoinment
    {
        public int AppoinmentId { get; set; }
        public string PatientId{ get; set; }
        public string DoctorId { get; set; }
        public DateTime AppoinmentDate { get; set; }
        public DateTime AppoinmentCreatedDate { get; set; }
        public string AppoinmentStatus { get; set; }

    }
}
