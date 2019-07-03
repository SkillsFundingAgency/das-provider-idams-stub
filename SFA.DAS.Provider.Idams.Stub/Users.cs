using System.Collections.Generic;
using System.Security.Claims;
using IdentityModel;
using SFA.DAS.Provider.Idams.Stub.Custom;

namespace SFA.DAS.Provider.Idams.Stub
{
    public class Users
    {
        public static List<ExtendedUser> Get()
        {
            var trainUGood = TrainingProviders.Get("10005077");
            var likeAPro = TrainingProviders.Get("10000896");

            return new List<ExtendedUser> {
                new ExtendedUser {
                    SubjectId = "5BE86359-073C-434B-AD2D-A3932222DABE",
                    Username = "chris",
                    //Password = "password",
                    ProviderId = trainUGood.Ukprn,
                    ProviderName = trainUGood.Name,
                    Description = "User with DAA role",
                    Claims = new List<Claim> {
                        new Claim(JwtClaimTypes.Email, "chrisfoster186@googlemail.com"),
                        new Claim(JwtClaimTypes.Role, "admin"),
                        new Claim(Custom.ClaimTypes.Ukprn, trainUGood.Ukprn),
                        new Claim(Custom.ClaimTypes.Service, "DAA"),
                        new Claim(Custom.ClaimTypes.Name, "Chris @ Train-U-Good Corporation"),
                        new Claim(Custom.ClaimTypes.DisplayName, "Chris @ Train-U-Good Corporation"),
                        new Claim(Custom.ClaimTypes.Upn, trainUGood.Ukprn + "\\" + "chris"),
                        new Claim(Custom.ClaimTypes.Email, "chrisfoster186@googlemail.com")
                    }
                },
                new ExtendedUser {
                    SubjectId = "fcea33d2-0bec-4fdd-8c97-5902973746a4",
                    Username = "duff",
                    //Password = "password",
                    ProviderId = trainUGood.Ukprn,
                    ProviderName = trainUGood.Name,
                    Description = "User without DAA role",
                    Claims = new List<Claim> {
                        new Claim(JwtClaimTypes.Email, "chrisfoster186@googlemail.com"),
                        new Claim(JwtClaimTypes.Role, "admin"),
                        new Claim(Custom.ClaimTypes.Ukprn, trainUGood.Ukprn),
                        //new Claim(Custom.ClaimTypes.Service, "DAA"), //this user does NOT have DAA role
                        new Claim(Custom.ClaimTypes.Name, "Duff @ Train-U-Good Corporation"),
                        new Claim(Custom.ClaimTypes.DisplayName, "Duff @ Train-U-Good Corporation"),
                        new Claim(Custom.ClaimTypes.Upn, trainUGood.Ukprn + "\\" + "duff"),
                        new Claim(Custom.ClaimTypes.Email, "chrisfoster186@googlemail.com")
                    }
                },
                new ExtendedUser {
                    SubjectId = "148cd9cb-9189-435d-a5ab-550bb800122d",
                    Username = "user1",
                    //Password = "password",
                    ProviderId = likeAPro.Ukprn,
                    ProviderName = likeAPro.Name,
                    Description = "User with DAA role",
                    Claims = new List<Claim> {
                        new Claim(JwtClaimTypes.Email, "chrisfoster186@googlemail.com"),
                        new Claim(JwtClaimTypes.Role, "admin"),
                        new Claim(Custom.ClaimTypes.Ukprn, likeAPro.Ukprn),
                        new Claim(Custom.ClaimTypes.Service, "DAA"),
                        new Claim(Custom.ClaimTypes.Name, "user1 @ Like a Pro Education Inc."),
                        new Claim(Custom.ClaimTypes.DisplayName, "user1 @ Like a Pro Education Inc."),
                        new Claim(Custom.ClaimTypes.Upn, likeAPro.Ukprn + "\\" + "user1"),
                        new Claim(Custom.ClaimTypes.Email, "chrisfoster186@googlemail.com")
                    }
                },
            };
        }
    }
}
