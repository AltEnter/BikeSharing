using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BikeSharing.Behaviors
{
    public class TurnValidOnFocusBehavior:Behavior<Entry>
    {
        public static BindableProperty ValidityObjectProperty =
            BindableProperty.Create(nameof(ValidityObject), typeof(object), typeof(TurnValidOnFocusBehavior));

        public object ValidityObject {
            get => GetValue(ValidityObjectProperty);
            set => SetValue(ValidityObjectProperty, value);
        }

        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);

            bindable.BindingContextChanged += OnBindingContextChanged;
            bindable.Focused += OnFucused;
        }

        private void OnFucused(object sender, FocusEventArgs e)
        {
            
        }

        private void OnBindingContextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
