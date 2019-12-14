using LifeCounterBT.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LifeCounterBT
{
    [DesignTimeVisible(false)]
    public partial class MainPageView : ContentPage
    {
        public MainPageView()
        {
            BindingContext = new MainPageViewModel();
            InitializeComponent();
        }
    }
}
