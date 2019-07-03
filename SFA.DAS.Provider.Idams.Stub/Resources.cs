using System.Collections.Generic;
using IdentityServer4.Models;

namespace SFA.DAS.Provider.Idams.Stub
{
    internal class Resources
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource> {
                new IdentityResources.OpenId(),
                new Custom.Resources.Idams(),
            };
        }
    }
}
