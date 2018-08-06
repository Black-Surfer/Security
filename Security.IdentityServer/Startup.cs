using IdentityServer3.Core.Configuration;
using Microsoft.Owin;
using Owin;
using Security.IdentityServer.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup(typeof(Security.IdentityServer.Startup))]
namespace Security.IdentityServer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var factory = new IdentityServerServiceFactory().UseInMemoryScopes(Scopes.Get())
                .UseInMemoryClients(Clients.Get())
                .UseInMemoryUsers(Users.Get());

            var options = new IdentityServerOptions
            {
                RequireSsl = false,
                Factory = factory,
                SigningCertificate = Certificate.Load(),
                SiteName = "X-Meet"
            };


            //setting up the owin for the identity server
            app.Map("/ids", idsrvapp =>
            {
                idsrvapp.UseIdentityServer(options);
            });


        }
    }
}