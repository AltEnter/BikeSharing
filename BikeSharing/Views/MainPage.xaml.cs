using BikeSharing.ViewModels;
using ReactiveUI.XamForms;

namespace BikeSharing.Views
{
    public partial class MainPage : ReactiveMasterDetailPage<MainViewModel>
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
