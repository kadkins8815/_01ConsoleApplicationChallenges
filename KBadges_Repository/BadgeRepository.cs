using KomodoInsurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBadges_Repository
{
    public class BadgeRepository
    {
        List<Badges> _listOfBadges = new List<Badges>();
        public void AddBadgesToList(Badges badgesObject)
        {
            _listOfBadges.Add(badgesObject);
        }
        public List<Badges> RetrunList()
        {
            return _listOfBadges;
        }

        public class Dictionary
        {
            public static void Main()
            {
                IDictionary<int, int> d = new Dictionary<int, int>();
                d.Add(1, 44);
                d.Add(2, 34);
                d.Add(3, 66);
                d.Add(4, 47);
                d.Add(5, 76);

                Console.WriteLine(d.Count);
            }
        }
    }
}
