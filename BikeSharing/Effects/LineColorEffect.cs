using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BikeSharing.Effects
{
    public static class LineColorEffect
    {
        public static BindableProperty ApplyLineColorProperty =
            BindableProperty.CreateAttached("ApplyLineColor", typeof(bool), typeof(LineColorEffect), false, propertyChanged: OnApplyLineColorChanged);

        public static bool GetApplyLineColor(BindableObject view) => (bool)view.GetValue(ApplyLineColorProperty);

        public static void SetApplyLineColor(BindableObject view, bool value) => view.SetValue(ApplyLineColorProperty, value);

        private static void OnApplyLineColorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var view = bindable as View;

            if (view == null)
                return;

            var hasShadow = (bool)newValue;

            if (hasShadow)
            {
                view.Effects.Add(new EntryLineColorEffect());
                view.Effects.Add(new DatePickerLineColorEffect());
                view.Effects.Add(new PickerLineColorEffect());
            }
            else
            {
                Effect entryLineColorEffectToRemove = view.Effects.FirstOrDefault(e => e is EntryLineColorEffect);
                if (entryLineColorEffectToRemove != null)
                {
                    view.Effects.Remove(entryLineColorEffectToRemove);
                }

                Effect datePickerLineColorEffectToRemove = view.Effects.FirstOrDefault(e => e is DatePickerLineColorEffect);
                if (datePickerLineColorEffectToRemove != null)
                {
                    view.Effects.Remove(datePickerLineColorEffectToRemove);
                }

                Effect pickerLineColorEffectToRemove = view.Effects.FirstOrDefault(e => e is PickerLineColorEffect);
                if (pickerLineColorEffectToRemove != null)
                {
                    view.Effects.Remove(pickerLineColorEffectToRemove);
                }
            }
        }

        public static BindableProperty LineColorProperty =
            BindableProperty.CreateAttached("LineColor", typeof(Color), typeof(LineColorEffect), Color.Default);

        public static Color GetLineColor(BindableObject view) => (Color)view.GetValue(LineColorProperty);

        public static void SetLineColor(BindableObject view,Color value) => view.SetValue(LineColorProperty,value);

        class DatePickerLineColorEffect : RoutingEffect
        {
            public DatePickerLineColorEffect() : base("BikeSharing.DatePickerLineColorEffect")
            {
            }
        }

        class EntryLineColorEffect : RoutingEffect
        {
            public EntryLineColorEffect() : base("BikeSharing.EntryLineColorEffect")
            {
            }
        }

        class PickerLineColorEffect : RoutingEffect
        {
            public PickerLineColorEffect() : base("PickerLineColorEffect")
            {
            }
        }
    }
}
