using System.Collections.Generic;
using System.Reactive.Linq;
using BikeSharing.Models;
using BikeSharing.Services.Interfaces;
using ReactiveUI;
using Splat;

namespace BikeSharing.ViewModels
{
    public class LoginViewModel : ViewModel
    {
        private IAuthenticationService _authenticationService;

        private User _user;

        public User User
        {
            get => _user;
            set => this.RaiseAndSetIfChanged(ref _user, value);
        }

        public ReactiveCommand Login { get; private set; }

        public LoginViewModel(IScreen hostScreen, IAuthenticationService authenticationService = null) : base(hostScreen)
        {
            _authenticationService = Locator.Current.GetService<IAuthenticationService>();
        }
    }
}
