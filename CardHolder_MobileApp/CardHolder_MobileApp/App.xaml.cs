using CardHolder_MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CardHolder_MobileApp
{
    public partial class App : Application
    {

        public static NavigationPage Navigator { get; set; }
        public static MasterPage Master { get; internal set; }


        public App()
        {
            InitializeComponent();

            //MainPage = new CardHolder_MobileApp.MainPage();

            MainPage = new CardHolder_MobileApp.Views.LoginPage();
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
