using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeSharing.Services.Interfaces
{
    public interface IAuthenticationService
    {
        bool IsAuthenticated { get; }

        Task<bool> LoginAsync(string userName, string password);

        Task LogoutAsync();

        int GetCurrentUserId();
    }
}
