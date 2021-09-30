using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceApp
{
    public class Developer
    {
        //name
        public string DevName { get; set; }
        
        //ID number
        public int DevID { get; set; }

        //pluralsight access
        public bool DevHasAccess { get; set; }

        //constructor
        public Developer() { }

        //constructor
        public Developer(string devname, int devid, bool devhasaccess)
        {
            DevName = devname;
            DevID = devid;
            DevHasAccess = devhasaccess;
        }
    }
}