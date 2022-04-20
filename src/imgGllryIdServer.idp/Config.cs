// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace imgGllryIdServer.idp
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            { 
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()

            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            { };

        public static IEnumerable<Client> Clients =>
            new Client[] 
            {
                new Client
                {
                     ClientName = "Image Gallery",
                     ClientId = "imagegalleryclient",
                     AllowedGrantTypes = GrantTypes.Code,
                     RedirectUris = new string[] {"https://localhost:44389/signin-oidc"},
                     PostLogoutRedirectUris = new string[]{ "https://localhost:44389/signin-oidc" },
                     AllowedScopes = new string[]
                     {
                         IdentityServerConstants.StandardScopes.Profile,
                         IdentityServerConstants.StandardScopes.OpenId
                     },
                     ClientSecrets = new Secret[]
                     {
                         new Secret("secret".Sha256())
                     }
                }
            };
    }
}