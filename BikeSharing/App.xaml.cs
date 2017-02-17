using BikeSharing.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BikeSharing
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            AdapColorsHexString();

            if (Device.OS == TargetPlatform.Windows)
                InitNavigation();
        }

        protected async override void OnStart()
        {
            base.OnStart();

            if (Device.OS != TargetPlatform.Windows)
                await InitNavigation();
        }

        private Task InitNavigation()
        {
            throw new NotImplementedException();
        }

        private void AdapColorsHexString()
        {
            for (var i = 0; i < Resources.Count; i++)
            {
                var key = Resources.Keys.ElementAt(i);
                var resource = Resources[key];
                if (resource is Color color)
                {
                    Resources.Add(key + "HexString", color.ToHexString());
                }
            }
        }
    }
}
