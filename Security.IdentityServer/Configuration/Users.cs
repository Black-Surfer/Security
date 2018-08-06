using IdentityServer3.Core;
using IdentityServer3.Core.Services.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace Security.IdentityServer.Configuration
{
    public class Users
    {
        public static List<InMemoryUser> Get()
        {
            return new List<InMemoryUser>
            {
                new InMemoryUser
            {
                Subject = "1",
                Username = "BO",
                Password = "password",
                Claims = new Claim[]
                {
                    new Claim(Constants.ClaimTypes.Name, "Giwa Uthman"),
                    new Claim(Constants.ClaimTypes.Email, "uthmangiwa@ymail.com"),
                    new Claim(Constants.ClaimTypes.PhoneNumber, "08144087702"),
                    new Claim(Constants.ClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(Constants.ClaimTypes.Address, "Isale eko"),
                    new Claim(Constants.ClaimTypes.BirthDate, "1972-1-8"),
                    new Claim(Constants.ClaimTypes.Role, "Admin")
                }
            },

                new InMemoryUser
            {
                Subject = "2",
                Username = "QUA",
                Password = "password",
                Claims = new Claim[]
                {
                    new Claim(Constants.ClaimTypes.Name, "Qua Huncho"),
                    new Claim(Constants.ClaimTypes.Email, "takeoff@qc.com"),
                    new Claim(Constants.ClaimTypes.PhoneNumber, "08144087702"),
                    new Claim(Constants.ClaimTypes.EmailVerified, "false", ClaimValueTypes.Boolean),
                    new Claim(Constants.ClaimTypes.Address, "Atlanta"),
                    new Claim(Constants.ClaimTypes.BirthDate, "1972-1-8"),
                    new Claim(Constants.ClaimTypes.Role, "Event")
                }
            },

            };
        }
    }
}