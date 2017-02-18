using System;
using System.Linq;
using System.Threading.Tasks;
using BikeSharing.Effects;
using BikeSharing.Utils;
using BikeSharing.ViewModels;
using Xamarin.Forms;

namespace BikeSharing
{
    public partial class App : Application
    {
        #region 可绑定属性
        public static readonly BindableProperty ApplyNumberOfLinesProperty =
            BindableProperty.CreateAttached("ApplyNumberOfLines", typeof(bool), typeof(MaxLinesEffect), false, propertyChanged: OnApplyNumberOfLinesChanged);

        private static void OnApplyNumberOfLinesChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var view = bindable as View;
            if (view == null)
                return;

            if ((bool)newValue)
            {
                view.Effects.Add(new MaxLinesEffect());
            }
            else
            {
                Effect toRemove = view.Effects.FirstOrDefault(e => e is MaxLinesEffect);
                if (toRemove != null)
                    view.Effects.Remove(toRemove);
            }
        }

        public bool ApplyNumberOfLines
        {
            get => (bool)GetValue(ApplyNumberOfLinesProperty);
            set => SetValue(ApplyNumberOfLinesProperty, value);
        }

        #endregion
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
