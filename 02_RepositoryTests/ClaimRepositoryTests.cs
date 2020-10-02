using System;
using _02_KClaims;
using _02_KClaims_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_RepositoryTests
{
    [TestClass]
    public class ClaimRepositoryTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            ClaimClass claim = new ClaimClass();
            ClaimRepository repository = new ClaimRepository();
        }
    }
}
