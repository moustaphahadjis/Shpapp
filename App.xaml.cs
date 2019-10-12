using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShpApp
{
    public partial class App : Application
    {
        public static string Dbpath;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
        public App(string location)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            Dbpath = location;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
