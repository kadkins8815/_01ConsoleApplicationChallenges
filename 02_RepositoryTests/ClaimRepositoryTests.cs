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
        
        [TestMethod]
        public void Update()
        {
            ClaimClass updatedClaim = new ClaimClass(2, "House fire in kitchen", 4000, "4.11.2018", "4.12.2018", true, ClaimType.Home);
            bool updateResult = _repo.UpdateExistingClaimClass(1, updatedClaim);
            Assert.IsTrue(updateResult);
        }
        [TestMethod]
        public void DeleteClaimFromList()
        {
            Assert.IsTrue(removeResult);
        }
    }
}
