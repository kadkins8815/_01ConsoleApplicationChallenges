using System;
using System.Security.Claims;
using _02_KClaims;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClaimClassTest
{
    [TestClass]
    public class ClaimClassTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            ClaimClass claimClass = new ClaimClass(1, "Car accident on 465", 400, "4.25.2018", "4.27.2018", true,ClaimType.Car);
            ClaimClass claimClass2 = new ClaimClass(2, "House fire in kitchen", 4000, "4.11.2018", "4.12.2018", true,ClaimType.Home);
            ClaimClass claimClass3 = new ClaimClass(3, "Stolen pancakes", 4, "4.27.2018", "6.01.2018",false, ClaimType.Theft);
        }
    }
}
