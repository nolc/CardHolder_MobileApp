using CardHolder_MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CardHolder_MobileApp.Services
{
    public class NavigationService
    {
        //public NavigationPage Navigator { get; set; }

        public NavigationService()
        {
            //Navigator = new NavigationPage();
        }

        public async void Navigate(string pageName)
        {
            switch (pageName)
            {             
                case "MainPage":
                    await Navigate(new MainPage());
                    break;

                //case "DetailPage":
                //    await Navigate(new DetailPage());
                //    break;

                default:
                    break;
            }
        }

        private static async Task Navigate<T>(T page) where T : Page
        {
            NavigationPage.SetHasBackButton(page, false);
            NavigationPage.SetBackButtonTitle(page, "Atrás"); //iOS

            switch (page.Title)
            {
                case "LoginPage":

                    await App.Navigator.PushAsync(page);

                    break;

                case "Ordenes": //MainPage

                    await App.Navigator.PushAsync(page);

                    break;

                case "DetailPage":

                    await App.Navigator.PushAsync(page);

                    break;

                default:
                    await App.Navigator.PushAsync(page);
                    break;
            }
        }

        internal void SetMainPage(string pageName)
        {
            switch (pageName)
            {
                case "MasterPage":
                    App.Current.MainPage = new MasterPage();
                    break;

                case "LoginPage":
                    App.Current.MainPage = new LoginPage();
                    break;

                case "MainPage":
                    App.Current.MainPage = new MainPage();
                    break;


                //case "DetailPage":
                //    App.Current.MainPage = new DetailPage();
                //    break;

                default:
                    break;
            }
        }
    }
}