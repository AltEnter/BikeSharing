using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeSharing.ViewModels;
using ReactiveUI.XamForms;
using Xamarin.Forms;

namespace BikeSharing.Pages
{
    public partial class LoginPage : ReactiveContentPage<LoginViewModel>
    {
        public LoginPage()
        {
            InitializeComponent();
        }
    }
}
