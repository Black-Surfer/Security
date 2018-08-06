using IdentityServer3.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Security.IdentityServer.Configuration
{
    public class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientName = "X Meet",
                    //Set if client is enabled 
                    Enabled = false,
                    //Allow access to all scopes(Insclidiign Identity scopes eg. OpenId
                    AllowAccessToAllScopes = true,
                    ClientId = "Avenger",
                    AccessTokenLifetime = 24 * 3600,
                    RefreshTokenUsage = TokenUsage.OneTimeOnly,
                    RefreshTokenExpiration = TokenExpiration.Absolute,
                    Flow = Flows.Implicit,
                    //Only set if allow access to all scope is false 
                    //AllowedScopes = new List<string>
                    //{
                    //    "Event Management",
                    //    "Admin Management"
                    //}
                    ClientSecrets =  new List<Secret>
                    {
                        new Secret("Hulk".Sha256())
                    }
                },
                 new Client
                {
                    ClientName = "Sample API",
                    Enabled = true,
                    //Allow access to all scopes(Insclidiign Identity scopes eg. OpenId
                    AllowAccessToAllScopes = true,
                    ClientId = "JusticeLeague",
                    AccessTokenLifetime = 24 * 3600,
                    RefreshTokenUsage = TokenUsage.ReUse,
                    RefreshTokenExpiration = TokenExpiration.Sliding,
                    Flow = Flows.ResourceOwner,
                    //Only set if allow access to all scope is false 
                    //AllowedScopes = new List<string>
                    //{
                    //    "Event Management",
                    //    "Admin Management"
                    //}
                    ClientSecrets =  new List<Secret>
                    {
                        new Secret("Batman".Sha256())
                    }
                }
            };
        }
    }
}