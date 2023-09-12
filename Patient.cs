using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD_Project
{
    class Patient: User
    {
        public Patient() { user_Type = "Patient"; }
        public DateTime DOB { get; set; }
        public string EmegencyContact { get; set; }
        public string BoodGroup { get; set; }
        public string Alergies { get; set; }
        public string Address { get; set; }
        public int Age{ get; set; }
    }
}
