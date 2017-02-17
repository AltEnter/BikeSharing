using BikeSharing.Application.Services;
using BikeSharing.Application.Services.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeSharing.Application.ViewModels
{
    public class ViewModelLocator
    {
        private readonly IUnityContainer _unityContainer;
        public static ViewModelLocator Instance => new ViewModelLocator();

        protected ViewModelLocator()
        {
            _unityContainer = new UnityContainer();

            //服务
            RegisterSingleton<INavigationService, NavigationService>();
        }

        private void RegisterSingleton<TInferface, T>() where T : TInferface
        {
            _unityContainer.RegisterType<TInferface, T>(new ContainerControlledLifetimeManager());
        }
    }
}
