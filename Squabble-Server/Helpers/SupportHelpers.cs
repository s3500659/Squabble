using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Squabble.Helpers
{
    public static class SupportHelpers
    {
        // get the current user ID from claims
        public static int FindIdFromToken(IEnumerable<Claim> claims)
        {
            return (from claim in claims where claim.Type.Equals("account_id") select int.Parse(claim.Value)).FirstOrDefault();
        }
    }
}
