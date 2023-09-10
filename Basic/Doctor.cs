using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD_Project.BasicClasses
{
    class Doctor:User
    {
        protected string specialization=null;
        protected List<Appoinment> appoinmentList=new List<Appoinment>();
        
        
        public Doctor() { user_Type = "Doctor"; }
        public string Specialization {
            get { return specialization; }
            set { specialization = value; }
        }
        public void checkpatient()
        {
            throw new NotImplementedException();
        }
        public void prescribeMedicine()
        {
            throw new NotImplementedException();
        }
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
