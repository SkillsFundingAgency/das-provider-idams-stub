using System.Collections.Generic;
using IdentityServer4;
using IdentityServer4.Models;

namespace SFA.DAS.Provider.Idams.Stub
{
    internal class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client> {
                new Client {
                    AllowAccessTokensViaBrowser = true,
                    ClientId = "openIdConnectClient",
                    ClientName = "Idams Stub Client",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    RequireConsent = false,
                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        Custom.Scopes.Idams
                    },
                    RedirectUris = new List<string> {"https://localhost:5001/signin-oidc", "https://127.0.0.1:44347/signin-oidc"},
                    PostLogoutRedirectUris = new List<string> { "https://localhost:5001" }
                }
            };
        }
    }
}
