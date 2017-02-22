using System.Collections.Generic;
using System.Reactive.Linq;
using BikeSharing.Models;
using BikeSharing.Services.Interfaces;
using ReactiveUI;
using Splat;
using Xamarin.Forms;

namespace BikeSharing.ViewModels
{
    public class LoginViewModel : ViewModel
    {
        private IAuthenticationService _authenticationService;

        public User User { get; set; }

        public ReactiveCommand Login { get; private set; }

        public LoginViewModel(IScreen hostScreen, IAuthenticationService authenticationService = null) : base(hostScreen)
        {
            User = new User();
            _authenticationService = Locator.Current.GetService<IAuthenticationService>();
        }
    }
}
