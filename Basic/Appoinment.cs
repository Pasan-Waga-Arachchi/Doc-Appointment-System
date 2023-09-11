using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD_Project.BasicClasses
{
    class Appoinment
    {
        private int appoinment_Id;
        private Doctor doctor = null;
        private Patient patient = null;
        private DateTime date;

        public int Appoinment_Id {
            get { return appoinment_Id; }
            set { appoinment_Id = value; }
        }
        public Patient Patient{
            get { return patient; }
            set { patient = value; }
        }
        public Doctor Doctor { 
            get { return doctor; } 
            set {  doctor = value; } 
        }    
        public DateTime Date { 
            get { return date; } 
            set {  date = value; } 
        }
    }
}
