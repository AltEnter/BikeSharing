using System;
using System.Threading.Tasks;
using BikeSharing.Services.Interfaces;
using BikeSharing.ViewModels;

namespace BikeSharing.Services
{
    public class NavigationService : INavigationService
    {
        private readonly IAuthenticationService _authenticationService;

        protected Xamarin.Forms.Application CurrentApplication => Xamarin.Forms.Application.Current;

        public NavigationService(IAuthenticationService authencationService)
        {
            _authenticationService = authencationService;
        }

        public Task InitializeAsync()
        {
            if (_authenticationService.IsAuthenticated)
                return NavigateToAsync<MainViewModel>();
            else
                return NavigateToAsync<LoginViewModel>();
        }

        public Task NavigateBackAsync()
        {
            throw new NotImplementedException();
        }

        public Task NavigateToAsync<TViewModel>() where TViewModel : ViewModel
        {
            throw new NotImplementedException();
        }

        public Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModel
        {
            throw new NotImplementedException();
        }

        public Task NavigateToAsync(Type viewModelType)
        {
            throw new NotImplementedException();
        }

        public Task NavigateToAsync(Type viewModelType, object parameter)
        {
            throw new NotImplementedException();
        }

        public Task RemoveLastFromBackStackAsync()
        {
            throw new NotImplementedException();
        }
    }
}
