using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeSharing.ViewModels;
using ReactiveUI.XamForms;
using Xamarin.Forms;
using ReactiveUI;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using BikeSharing.Effects;

namespace BikeSharing.Views
{
    public partial class LoginPage : ReactiveContentPage<LoginViewModel>
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            this.WhenActivated(disposables =>
            {
                this.WhenAnyValue(v => v.ViewModel)
                        .Subscribe(vm => BindingContext = vm)
                        .DisposeWith(disposables);
            });
        }
    }
}
