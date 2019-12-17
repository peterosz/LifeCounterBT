using LifeCounterBT.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LifeCounterBT
{
    public partial class App : Application
    {
        public static string DbFilePath;

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        public App( string dbFilePath)
        {
            InitializeComponent();

            DbFilePath = dbFilePath;

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
