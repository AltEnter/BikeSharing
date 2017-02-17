using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BikeSharing.Effects
{
    public static class NumberOfLinesEffect
    {
        public static readonly BindableProperty ApplyNumberOfLinesProperty =
            BindableProperty.CreateAttached("ApplyNumberOfLines", typeof(bool), typeof(NumberOfLinesEffect), false, propertyChanged: OnApplyNumberOfLinesChanged);

        private static void OnApplyNumberOfLinesChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var view = bindable as View;
            if (view == null)
                return;

            var hasShadow = (bool)newValue;
            if (hasShadow)
                view.Effects.Add(new MaxLinesEffect());
        }

        private class MaxLinesEffect : RoutingEffect
        {
            public MaxLinesEffect() : base("BikeSharing.MaxLinesEffect")
            {
            }
        }
    }
}
