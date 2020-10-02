using System;
using System.Collections.Generic;
using _02_KClaims;
using _02_KClaims_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_RepositoryTests
{
    [TestClass]
    public class ClaimRepositoryTests
    {

        [TestMethod]
        public void GetList()
        {
            //Arrange
            ClaimClass newObject = new ClaimClass();
            ClaimRepository repo = new ClaimRepository();
            repo.AddClaimToList(newObject);

            //Act
            List<ClaimClass> listofClaims = repo.GetClaimClassList();

            //Assert
            bool directoryHasContent = listofClaims.Contains(newObject);
            Assert.IsTrue(directoryHasContent);
        }
        private ClaimRepository _repo;
        private ClaimClass _content;
        private bool removeResult;

        public void Arrange()
        {
            _repo = new ClaimRepository();
            _content = new ClaimClass(1, "Car accident on 465", 400, "4.25.2018", "4.27.2018", true, ClaimType.Car);
            _repo.AddClaimToList(_content);
        }
    }
}
