using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsurance
{
    public class Badges
    {
        public string BadgeID { get; set; }
        public string DoorNames { get; set; }
        public Badges()
        {

        }

        public Badges(string badgeID, string doorNames)
        {
            BadgeID = badgeID;
            DoorNames = doorNames;
        }
    }
}
