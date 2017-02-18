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
            BindableProperty.CreateAttached("ApplyNumberOfLines", typeof(bool), typeof(App), false, propertyChanged: OnApplyNumberOfLinesChanged);

        public static bool GetApplyNumberofLines(BindableObject view) => (bool)view.GetValue(ApplyNumberOfLinesProperty);

        public static void SetApplyNumberOfLines(BindableObject view, bool value) => view.SetValue(ApplyNumberOfLinesProperty, value);

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

        public static readonly BindableProperty NumberOfLinesProperty =
            BindableProperty.CreateAttached("NumberOfLines", typeof(int), typeof(App), 1);

        public static int GetNumberOfLines(BindableObject view) => (int)view.GetValue(NumberOfLinesProperty);

        public static void SetNumberOfLines(BindableObject view,int value) => view.SetValue(NumberOfLinesProperty,value);


        public class MaxLinesEffect : RoutingEffect
        {
            public MaxLinesEffect() : base("BikeSharing.MaxLinesEffect")
            {
            }
        }
    }
}
