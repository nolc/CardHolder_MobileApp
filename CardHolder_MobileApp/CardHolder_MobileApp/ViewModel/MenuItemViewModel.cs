using GalaSoft.MvvmLight.Command;
using CardHolder_MobileApp.Services;
using CardHolder_MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace CardHolder_MobileApp.ViewModel
{
    public class MenuItemViewModel
    {
        private NavigationService navigationService;

        public MenuItemViewModel()
        {
            navigationService = new NavigationService();
        }

        public string Icon { get; set; }

        public string Title { get; set; }

        public string PageName { get; set; }

        public ICommand NavigateCommand
        {
            get
            {
                return new RelayCommand(() => navigationService.Navigate(PageName));
            }
        }
    }
}