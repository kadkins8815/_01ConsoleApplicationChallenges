using System;
using System.Collections.Generic;
using KBadges_Repository;
using KomodoInsurance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KBadges_UnitTest
{
    [TestClass]
    public class Kbadges_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            Badges badges = new Badges();
            badges.BadgeID = "1,2,3,4,5";
            BadgeRepository repo = new BadgeRepository();
            repo.AddBadgesToList(badges);

            List<Badges> localList = repo.RetrunList();

           

           
        }
    }
}
