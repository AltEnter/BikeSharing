using System;
using System.Linq;
using System.Threading.Tasks;
using BikeSharing.Utils;
using BikeSharing.ViewModels;
using Xamarin.Forms;

namespace BikeSharing
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            AdapColorsHexString();

            MainPage = (new AppViewModel()).CreateMainPage();
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
