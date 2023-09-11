using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAD_Project.BasicClasses
{
    abstract class User
    {

       public string Name { get; set; }
        public string Password { get; set; }
        public string ID { get; set; }
        public string gender { get; set; }
        protected string UserType { get; set; }
    }
}
