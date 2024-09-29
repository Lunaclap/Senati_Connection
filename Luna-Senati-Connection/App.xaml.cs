using LunaSenatiConnection.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LunaSenatiConnection
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            App.Current.MainPage = new NavigationPage(new Login());
            NavigationPage.SetHasNavigationBar(MainPage, false);
            //MainPage = new MainPage();
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
