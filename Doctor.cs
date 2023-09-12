using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD_Project
{
    class Doctor : User
    {
        public Doctor (){ user_Type = "Doctor"; }
        public DateTime DateTime { get; set; }
        public string MedicalLicenseNo { get; set; }
        public string Specialization { get; set;}
        public string Qualification{ get; set;}
        public string Hostpital{ get; set;}
        public int YearsOfExp { get; set;}

    }
}
