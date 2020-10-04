using _02_KClaims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KClaims_Repository
{
    //POCO
    public class ClaimRepository
    {
        private List<ClaimClass> _listOfClaimClass = new List<ClaimClass>();

        //C
        public void AddClaimToList(ClaimClass claim)
        {
            _listOfClaimClass.Add(claim);
        }

        //R
        
        public List<ClaimClass> GetClaimClassList()
        {
            return _listOfClaimClass;
        }

        //U
        public bool UpdateExistingClaimClass(string orginalClaimID, ClaimClass newClaimClass)
        {
            //Find
            ClaimClass oldClaim = GetClaimClassByClaimID(orginalClaimID);
            
            //Update
            if(oldClaim != null)
            {
                oldClaim.ClaimID = newClaimClass.ClaimID;
                oldClaim.TypesOfClaims = newClaimClass.TypesOfClaims;
                oldClaim.Description = newClaimClass.Description;
                oldClaim.ClaimAmount = newClaimClass.ClaimAmount;
                oldClaim.DateOfAccident = newClaimClass.DateOfAccident;
                oldClaim.DateOfClaim = newClaimClass.DateOfClaim;
                oldClaim.IsValid = newClaimClass.IsValid;

                return true;
            }
            else
            {
                return false;
            }
        }

        //D
        public bool DeleteClaimFromList(ClaimClass claimsClass)
        {
            ClaimClass claim = GetClaimClassByClaimID("1");
            if(claim == null)
            {
                return false;
            }

            int initialCount = _listOfClaimClass.Count;
            _listOfClaimClass.Remove(claim);
            if(initialCount > _listOfClaimClass.Count)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Helper Method
        private ClaimClass GetClaimClassByClaimID(string claimID)
        {
            foreach (ClaimClass claim in _listOfClaimClass)
            {
                if(claim.ClaimID == claimID)
                {
                   return claim;
              }
           }

            return null;
        }
    }
}
