using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ContractClaimSystem.Models;
using ContractClaimSystem.Controllers;

namespace ContractClaimSystem.Controllers
{
    public class CoordinatorsAndManagersController : Controller
    {
        // Use the same static list of claims as LecturerController
        private static List<Claim> claims = LecturerController.claims;

        // Action to display the claims
        public IActionResult ReviewClaims()
        {
            return View(claims); // Pass the list of claims to the view
        }

        // POST: Approve claim
        [HttpPost]
        public IActionResult ApproveClaim(int claimId)
        {
            var claim = claims.FirstOrDefault(c => c.ClaimId == claimId);
            if (claim != null)
            {
                claim.Status = "Approved";
            }
            return RedirectToAction("ReviewClaims"); // Refresh the view
        }

        // POST: Reject claim
        [HttpPost]
        public IActionResult RejectClaim(int claimId)
        {
            var claim = claims.FirstOrDefault(c => c.ClaimId == claimId);
            if (claim != null)
            {
                claim.Status = "Rejected";
            }
            return RedirectToAction("ReviewClaims"); // Refresh the view
        }
    }
}
