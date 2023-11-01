using Eventures.Tests.Helpers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http.Headers;
using Xunit;

namespace Eventures.Tests
{
    public class IntegrationTests : IClassFixture<CustomWebApplicationFactory<Program>>
    {
        private readonly CustomWebApplicationFactory<Program> _factory;

        public IntegrationTests(CustomWebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task TestIfYouCanGetTheIndexPageAsAnUnauthenticatedUser()
        {
            var client = GetClient();

            var response = await client.GetAsync("/");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanGetTheIndexPageAsALoggedInUserWithRoleUser()
        {
            var client = GetAuthClientUser();

            var response = await client.GetAsync("/");
            var content = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.True(content.Contains("Welcome, "));
        }

        [Fact]
        public async Task TestIfYouCanGetTheIndexPageAsALoggedInUserWithRoleAdmin()
        {
            var client = GetAuthClientAdmin();

            var response = await client.GetAsync("/");
            var content = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.True(content.Contains("Greetings, Administrator - "));
        }

        [Fact]
        public async Task TestIfYouCanAccessMyEventsAsAnUnauthenticatedUser()
        {
            var client = GetClient();

            var response = await client.GetAsync("/Events/MyEvents");

            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessMyEventsAsALoggedInUserWithRoleUser()
        {
            var client = GetAuthClientUser();

            var response = await client.GetAsync("/Events/MyEvents");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessMyEventsAsALoggedInUserWithRoleAdmin()
        {
            var client = GetAuthClientAdmin();

            var response = await client.GetAsync("/Events/MyEvents");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessAllEventsAsAnUnauthenticatedUser()
        {
            var client = GetClient();

            var response = await client.GetAsync("/Events/All");

            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessAllEventsAsALoggedInUserWithRoleUser()
        {
            var client = GetAuthClientUser();

            var response = await client.GetAsync("/Events/All");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessAllEventsAsALoggedInUserWithRoleAdmin()
        {
            var client = GetAuthClientAdmin();

            var response = await client.GetAsync("/Events/All");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessCreateEventAsAnUnauthenticatedUser()
        {
            var client = GetClient();

            var response = await client.GetAsync("/Events/Create");

            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessCreateEventAsALoggedInUserWithRoleUser()
        {
            var client = GetAuthClientUser();

            var response = await client.GetAsync("/Events/Create");

            Assert.Equal(HttpStatusCode.Forbidden, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessCreateEventAsALoggedInUserWithRoleAdmin()
        {
            var client = GetAuthClientAdmin();

            var response = await client.GetAsync("/Events/Create");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessAllOrdersAsAnUnauthenticatedUser()
        {
            var client = GetClient();

            var response = await client.GetAsync("/Orders/All");

            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessAllOrdersAsALoggedInUserWithRoleUser()
        {
            var client = GetAuthClientUser();

            var response = await client.GetAsync("/Orders/All");

            Assert.Equal(HttpStatusCode.Forbidden, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessAllOrdersAsALoggedInUserWithRoleAdmin()
        {
            var client = GetAuthClientAdmin();

            var response = await client.GetAsync("/Orders/All");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessPromoteUserAsAnUnauthenticatedUser()
        {
            var client = GetClient();

            var response = await client.GetAsync("/Users/Promote");

            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessPromoteUserAsALoggedInUserWithRoleUser()
        {
            var client = GetAuthClientUser();

            var response = await client.GetAsync("/Users/Promote");

            Assert.Equal(HttpStatusCode.Forbidden, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessPromoteUserAsALoggedInUserWithRoleAdmin()
        {
            var client = GetAuthClientAdmin();

            var response = await client.GetAsync("/Users/Promote");

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessDemoteUserAsAnUnauthenticatedUser()
        {
            var client = GetClient();

            var response = await client.GetAsync("/Users/Demote");

            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessDemoteUserAsALoggedInUserWithRoleUser()
        {
            var client = GetAuthClientUser();

            var response = await client.GetAsync("/Users/Demote");

            Assert.Equal(HttpStatusCode.Forbidden, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessDemoteUserAsALoggedInUserWithRoleAdmin()
        {
            var client = GetAuthClientAdmin();

            var response = await client.GetAsync("/Users/Demote");

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessAdministrationAsAnUnauthenticatedUser()
        {
            var client = GetClient();

            var response = await client.GetAsync("/Users/Administration");

            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessAdministrationAsALoggedInUserWithRoleUser()
        {
            var client = GetAuthClientUser();

            var response = await client.GetAsync("/Users/Administration");

            Assert.Equal(HttpStatusCode.Forbidden, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessAdministrationAsALoggedInUserWithRoleAdmin()
        {
            var client = GetAuthClientAdmin();

            var response = await client.GetAsync("/Users/Administration");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessExternalLoginAsAnUnauthenticatedUser()
        {
            var client = GetClient();

            var response = await client.GetAsync("/Users/ExternalLogin");

            Assert.Equal(HttpStatusCode.Redirect, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessExternalLoginAsALoggedInUserWithRoleUser()
        {
            var client = GetAuthClientUser();

            var response = await client.GetAsync("/Users/ExternalLogin");

            Assert.Equal(HttpStatusCode.UnprocessableEntity, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessExternalLoginAsALoggedInUserWithRoleAdmin()
        {
            var client = GetAuthClientAdmin();

            var response = await client.GetAsync("/Users/ExternalLogin");

            Assert.Equal(HttpStatusCode.UnprocessableEntity, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessFinishExternalLoginAsAnUnauthenticatedUser()
        {
            var client = GetClient();

            var response = await client.GetAsync("/Users/FinishExternalLogin");

            Assert.Equal(HttpStatusCode.Redirect, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessFinishExternalLoginAsALoggedInUserWithRoleUser()
        {
            var client = GetAuthClientUser();

            var response = await client.GetAsync("/Users/FinishExternalLogin");

            Assert.Equal(HttpStatusCode.UnprocessableEntity, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessFinishExternalLoginAsALoggedInUserWithRoleAdmin()
        {
            var client = GetAuthClientAdmin();

            var response = await client.GetAsync("/Users/FinishExternalLogin");

            Assert.Equal(HttpStatusCode.UnprocessableEntity, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessLoginAsAnUnauthenticatedUser()
        {
            var client = GetClient();

            var response = await client.GetAsync("/Users/Login");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccesslLoginAsALoggedInUserWithRoleUser()
        {
            var client = GetAuthClientUser();

            var response = await client.GetAsync("/Users/Login");

            Assert.Equal(HttpStatusCode.UnprocessableEntity, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessLoginAsALoggedInUserWithRoleAdmin()
        {
            var client = GetAuthClientAdmin();

            var response = await client.GetAsync("/Users/Login");

            Assert.Equal(HttpStatusCode.UnprocessableEntity, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessRegisterAsAnUnauthenticatedUser()
        {
            var client = GetClient();

            var response = await client.GetAsync("/Users/Register");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccesslRegisterAsALoggedInUserWithRoleUser()
        {
            var client = GetAuthClientUser();

            var response = await client.GetAsync("/Users/Register");

            Assert.Equal(HttpStatusCode.UnprocessableEntity, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessRegisterAsALoggedInUserWithRoleAdmin()
        {
            var client = GetAuthClientAdmin();

            var response = await client.GetAsync("/Users/Register");

            Assert.Equal(HttpStatusCode.UnprocessableEntity, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessLogoutAsAnUnauthenticatedUser()
        {
            var client = GetClient();

            var response = await client.GetAsync("/Users/Logout");

            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccesslLogoutAsALoggedInUserWithRoleUser()
        {
            var client = GetAuthClientUser();

            var response = await client.GetAsync("/Users/Logout");

            Assert.Equal(HttpStatusCode.Redirect, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessLogoutAsALoggedInUserWithRoleAdmin()
        {
            var client = GetAuthClientAdmin();

            var response = await client.GetAsync("/Users/Logout");

            Assert.Equal(HttpStatusCode.Redirect, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessLoginPostAsAnUnauthenticatedUser()
        {
            var client = GetClient();

            var response = await client.PostAsync("/Users/Login", null);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccesslLoginPostAsALoggedInUserWithRoleUser()
        {
            var client = GetAuthClientUser();

            var response = await client.PostAsync("/Users/Login", null);

            Assert.Equal(HttpStatusCode.UnprocessableEntity, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessLoginPostAsALoggedInUserWithRoleAdmin()
        {
            var client = GetAuthClientAdmin();

            var response = await client.PostAsync("/Users/Login", null);

            Assert.Equal(HttpStatusCode.UnprocessableEntity, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessRegisterPostAsAnUnauthenticatedUser()
        {
            var client = GetClient();

            var response = await client.PostAsync("/Users/Register", null);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccesslRegisterPostAsALoggedInUserWithRoleUser()
        {
            var client = GetAuthClientUser();

            var response = await client.PostAsync("/Users/Register", null);

            Assert.Equal(HttpStatusCode.UnprocessableEntity, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessRegisterPostAsALoggedInUserWithRoleAdmin()
        {
            var client = GetAuthClientAdmin();

            var response = await client.PostAsync("/Users/Register", null);

            Assert.Equal(HttpStatusCode.UnprocessableEntity, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessExternalLoginPostAsAnUnauthenticatedUser()
        {
            var client = GetClient();

            var response = await client.PostAsync("/Users/ExternalLogin", null);

            //This will return unauthorized because we are not getting a token from Facebook. We need a token for the post
            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessExternalLoginPostAsALoggedInUserWithRoleUser()
        {
            var client = GetAuthClientUser();

            var response = await client.PostAsync("/Users/ExternalLogin", null);

            Assert.Equal(HttpStatusCode.UnprocessableEntity, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessExternalLoginPostAsALoggedInUserWithRoleAdmin()
        {
            var client = GetAuthClientAdmin();

            var response = await client.PostAsync("/Users/ExternalLogin", null);

            Assert.Equal(HttpStatusCode.UnprocessableEntity, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessFinishExternalLoginPostAsAnUnauthenticatedUser()
        {
            var client = GetClient();

            var response = await client.PostAsync("/Users/FinishExternalLogin", null);

            Assert.Equal(HttpStatusCode.Redirect, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessFinishExternalLoginPostAsALoggedInUserWithRoleUser()
        {
            var client = GetAuthClientUser();

            var response = await client.PostAsync("/Users/FinishExternalLogin", null);

            Assert.Equal(HttpStatusCode.UnprocessableEntity, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessFinishExternalLoginPostAsALoggedInUserWithRoleAdmin()
        {
            var client = GetAuthClientAdmin();

            var response = await client.PostAsync("/Users/FinishExternalLogin", null);

            Assert.Equal(HttpStatusCode.UnprocessableEntity, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessOrderPostAsAnUnauthenticatedUser()
        {
            var client = GetClient();

            var response = await client.PostAsync("/Orders/Order", null);

            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessOrderPostAsALoggedInUserWithRoleUser()
        {
            var client = GetAuthClientUser();

            var response = await client.PostAsync("/Orders/Order", null);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessOrderPostAsALoggedInUserWithRoleAdmin()
        {
            var client = GetAuthClientAdmin();

            var response = await client.PostAsync("/Orders/Order", null);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessCreateEventPostAsAnUnauthenticatedUser()
        {
            var client = GetClient();

            var response = await client.PostAsync("/Events/Create", null);

            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessCreateEventPostAsALoggedInUserWithRoleUser()
        {
            var client = GetAuthClientUser();

            var response = await client.PostAsync("/Events/Create", null);

            Assert.Equal(HttpStatusCode.Forbidden, response.StatusCode);
        }

        [Fact]
        public async Task TestIfYouCanAccessCreateEventPostAsALoggedInUserWithRoleAdmin()
        {
            var client = GetAuthClientAdmin();

            var response = await client.PostAsync("/Events/Create", null);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        private HttpClient GetClient()
        {
            var client = _factory.CreateClient(
                new WebApplicationFactoryClientOptions
                {
                    AllowAutoRedirect = false
                });

            return client;
        }

        private HttpClient GetAuthClientUser()
        {
            var client = _factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureTestServices(services =>
                {
                    services.AddAuthentication(o =>
                    {
                        o.DefaultAuthenticateScheme = "TestScheme";
                        o.DefaultChallengeScheme = "TestScheme";
                    })
                        .AddScheme<AuthenticationSchemeOptions, TestAuthHandlerUser>(
                            "TestScheme", options => { });
                });
            })
                .CreateClient(new WebApplicationFactoryClientOptions
                {
                    AllowAutoRedirect = false,
                });

            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(scheme: "TestScheme");

            return client;
        }

        private HttpClient GetAuthClientAdmin()
        {
            var client = _factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureTestServices(services =>
                {
                    services.AddAuthentication(o =>
                    {
                        o.DefaultAuthenticateScheme = "TestScheme";
                        o.DefaultChallengeScheme = "TestScheme";
                    })
                        .AddScheme<AuthenticationSchemeOptions, TestAuthHandlerAdmin>(
                            "TestScheme", options => { });
                });
            })
                .CreateClient(new WebApplicationFactoryClientOptions
                {
                    AllowAutoRedirect = false,
                });

            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(scheme: "TestScheme");

            return client;
        }
    }
}
