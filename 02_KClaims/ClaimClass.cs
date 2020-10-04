using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KClaims
{
   public enum ClaimType
    {
        Car = 1,
        Home,
        Theft,
    }
    public class ClaimClass
    {
        public string ClaimID { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public string DateOfAccident { get; set; }
        public string DateOfClaim { get; set; }
        public bool IsValid { get; set; }
        public ClaimType TypesOfClaims { get; set; }
       

        public ClaimClass() { }

        public ClaimClass(string claimID, string description, double claimAmount, string dateOfAccident, string dateofClaim, bool isValid, ClaimType tOC)
        {
            ClaimID = claimID;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfAccident = dateOfAccident;
            DateOfClaim = dateOfAccident;
            IsValid = isValid;
            TypesOfClaims = TypesOfClaims;
           
        }
    }
}
