using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD_Project
{
    class Patient: User
    {
        public Patient() { UserType = "Patient"; }
        public DateTime DOB {  get; set; }
        public string EmergencyContact { get; set; } 
        public string Alergies { get; set; }
        public string BloodType { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
}
