using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD_Project.BasicClasses
{
    abstract class User
    {
        protected int user_Id;
        protected string user_Name;
        protected string user_Phone;
        protected string user_Type;


        public int Staff_Id {
            get { return user_Id; }
            set {user_Id = value;} 
        }
        public string Name
        {
            get { return user_Name; }
            set {user_Name = (string)value;}
        }
        public string Phone
        {
            get { return user_Phone; }
            set {user_Phone = (string)value;}
        }
        public string User_Type
        {
            get { return user_Type; }
        }
    }
}
