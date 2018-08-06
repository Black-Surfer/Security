using IdentityServer3.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Security.IdentityServer.Configuration
{
    public class Scopes
    {
        public static IEnumerable<Scope> Get()
        {
            return new[]
            {
                StandardScopes.OpenId ,
                StandardScopes.Profile,

                new Scope
                {
                    Name = "EventManagement",
                    DisplayName = "Event Management",
                    Type = ScopeType.Resource,
                    Emphasize = false,
                    ScopeSecrets = new List<Secret>
                    {
                        new Secret("Marvel".Sha256())
                    }
                },
                new Scope
                {
                    Name = "AdminManagement",
                    DisplayName = "Admin Management",
                    Type = ScopeType.Resource,
                    Emphasize = false,
                    ScopeSecrets = new List<Secret>
                    {
                        new Secret("DC".Sha256())
                    }
                },

            };
        }
    }
}