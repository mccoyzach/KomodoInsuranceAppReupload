using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceApp
{
    public class DevTeam
    {
        // team name
        public string TeamName { get; set; }

        //ID number
        public int TeamID { get; set; }
        
        //Team member name
        public int TeamMember { get; set; }
        
        //constructor
        public DevTeam() { }
        
        //constructor
        public DevTeam(string teamname, int teamid, int devid)
        {
            TeamName = teamname;
            TeamID = teamid;
            TeamMember = devid;
        }

    }
}