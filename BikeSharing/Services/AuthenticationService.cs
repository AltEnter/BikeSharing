using BikeSharing.Services.Interfaces;
using System;
using System.Threading.Tasks;
using BikeSharing.Helpers;

namespace BikeSharing.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public bool IsAuthenticated => !string.IsNullOrEmpty(Settings.AccessToken);

        public int GetCurrentUserId()
        {
            throw new NotImplementedException();
        }

        public Task<bool> LoginAsync(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public Task LogoutAsync()
        {
            throw new NotImplementedException();
        }
    }
}
