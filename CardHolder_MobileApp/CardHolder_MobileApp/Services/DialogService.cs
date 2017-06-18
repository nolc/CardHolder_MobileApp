using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardHolder_MobileApp.Services
{
    public class DialogService
    {
        public async Task ShowMessage(string message, string title)
        {
            await App.Current.MainPage.DisplayAlert(title, message, "OK");
        }
    }
}
