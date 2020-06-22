using System.Collections.Generic;
using X247.IdentityServer.Admin.Configuration.Identity;

namespace X247.IdentityServer.Admin.Configuration.IdentityServer
{
    public class Client : global::IdentityServer4.Models.Client
    {
        public List<Claim> ClientClaims { get; set; } = new List<Claim>();
    }
}






