using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeSharing.ViewModels
{
    public class AppViewModel : ReactiveObject, IScreen
    {
        public RoutingState Router { get; protected set; }

        public AppViewModel()
        {
            Router = new RoutingState();
            Locator.CurrentMutable.RegisterConstant(this, typeof(IScreen));
        }
    }
}
