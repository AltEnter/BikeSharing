using System;
using BikeSharing.Pages;
using BikeSharing.Services;
using BikeSharing.Services.Interfaces;
using ReactiveUI;
using ReactiveUI.XamForms;
using Splat;
using Xamarin.Forms;

namespace BikeSharing.ViewModels
{
    public class AppViewModel : ReactiveObject, IScreen
    {
        private readonly IAuthenticationService _authenticationService;

        public RoutingState Router { get; private set; }

        public AppViewModel(IMutableDependencyResolver dependencyResolver = null, RoutingState router = null)
        {
            dependencyResolver = dependencyResolver ?? Locator.CurrentMutable;
            Router = router ?? new RoutingState();

            dependencyResolver.RegisterConstant(this, typeof(IScreen));

            //RegisterProviders(dependencyResolver);
            RegisterServices(dependencyResolver);
            RegisterNavigablePages(dependencyResolver);

            _authenticationService = dependencyResolver.GetService<IAuthenticationService>();
            InitNavigation();
        }

        private void RegisterNavigablePages(IMutableDependencyResolver dependencyResolver)
        {
            dependencyResolver.Register(() => new LoginPage(), typeof(LoginViewModel));
            dependencyResolver.Register(() => new MainPage(), typeof(MainViewModel));
        }

        private void RegisterServices(IMutableDependencyResolver dependencyResolver)
        {
            dependencyResolver.Register(() => new AuthenticationService(), typeof(IAuthenticationService));
        }

        private void RegisterProviders(IMutableDependencyResolver dependencyResolver)
        {
            throw new NotImplementedException();
        }

        private void InitNavigation()
        {
            if (_authenticationService.IsAuthenticated)
                Router.Navigate.Execute(new MainViewModel(this));
            else
                Router.Navigate.Execute(new LoginViewModel(this));
        }

        public Page CreateMainPage() => new RoutedViewHost();
    }
}
