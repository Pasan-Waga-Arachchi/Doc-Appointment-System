using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD_Project
{
    public class Doctor : User
    {
        public Doctor (){ user_Type = "Doctor"; }
        public int Doctor_ID { get; set; }
        public string Doctor_Name { get; set; }
        public string Gender { get; set; }
        public  string ContactNo { get; set; }  
        public string Time { get; set; }
        public string MLN { get; set; }
        public string Specialization { get; set;}
        public string Qualification{ get; set;}
        public string Hostpital{ get; set;}
        public int YearsOfExp { get; set;}

    }
}
