using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeSharing.ViewModels
{
    public class ViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment { get; protected set; }

        public IScreen HostScreen { get; protected set; }

        public ViewModel(IScreen hostScreen=null)
        {
            HostScreen = hostScreen ?? Locator.Current.GetService<IScreen>();
        }
    }
}
