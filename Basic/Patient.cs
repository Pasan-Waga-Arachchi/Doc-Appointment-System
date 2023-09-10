using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD_Project.BasicClasses
{
    class Patient: User
    {
        public Patient() { user_Type = "Patient"; }
        private int age;
        private string deseace;
        private List<Appoinment> appoinmentList=new List<Appoinment>();
        
        
        public int Age { 
            get { return age; } 
            set { 
                if(value < 0 || value >120) throw new ArgumentOutOfRangeException("Invalid Age");
                else age = value;    
            } 
        }
        public string Deseace
        {
            get { return deseace; }
            set { deseace=value; }
        }
        public void chooseDoctor(){ throw new NotImplementedException(); }
        public void chooseDate() { throw new NotImplementedException(); }
        public void payBill() { throw new NotImplementedException(); }
        public void addAppoinment(Appoinment appoinment)
        {
            appoinmentList.Add(appoinment);
        }
        public void removeAppoinment(Appoinment appoinment)
        {
            appoinmentList.Remove(appoinment);
        }
    }
}
