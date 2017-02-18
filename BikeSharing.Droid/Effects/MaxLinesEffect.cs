using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using BikeSharing.Droid.Effects;
using BikeSharing.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportEffect(typeof(MaxLinesEffect),"MaxLinesEffect")]
namespace BikeSharing.Droid.Effects
{
    public class MaxLinesEffect : PlatformEffect
    {
        private TextView _control;

        protected override void OnAttached()
        {
            _control = Control as TextView;
            SetMaxLines();
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            if (args.PropertyName == NumberOfLinesEffect.NumberOfLinesProperty.PropertyName)
                SetMaxLines();
        }

        private void SetMaxLines()
        {
            _control.SetMaxLines(NumberOfLinesEffect.GetNumberOfLines(Element));
        }

        protected override void OnDetached()
        {
        }
    }
}