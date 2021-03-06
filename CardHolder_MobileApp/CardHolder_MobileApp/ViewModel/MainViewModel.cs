﻿//using CardHolder_MobileApp.Model;
using CardHolder_MobileApp.Views;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CardHolder_MobileApp.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        //OrdenVentaModel mascotaService;


        public ObservableCollection<MenuItemViewModel> Menu { get; set; }


        private string _texto;

        public string Texto
        {
            get {

                _texto = "Hola mundo";

                return _texto;
            }
            set {

                _texto = value;


                OnPropertyChanged();
            }
        }




        #region Menu

        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();

            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_conciliacion.png",
                PageName = "MainPage",
                Title = "Conciliación",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_exit.png",
                PageName = "LoginPage",
                Title = "Cerrar sesión",
            });
        }

        #endregion

        public MainViewModel()
        {
            //base.navigationService = new Services.NavigationService();

            LoadMenu();

            //  mascotaService = new OrdenVentaModel();

            //SearchOrdenVenta();
        }

        //ObservableCollection<OrdenVenta> _ordenVenta;
        //public ObservableCollection<OrdenVenta> OrdenVenta
        //{
        //    get
        //    {
        //        if (Application.Current.Properties.ContainsKey("ListOrdenVenta") && Application.Current.Properties["ListOrdenVenta"] != null)
        //            _ordenVenta = (ObservableCollection<OrdenVenta>)Application.Current.Properties["ListOrdenVenta"];

        //        return _ordenVenta;
        //    }
        //    set
        //    {
        //        _ordenVenta = value;

        //        OnPropertyChanged();
        //    }
        //}

        //OrdenVenta _selectedItem;
        //public OrdenVenta SelectedItem
        //{
        //    get
        //    {               
        //        //if (_selectedItem != null)
        //        //    Application.Current.MainPage.Navigation.PushAsync(new DetailPage());

        //        //App.Navigator.PushAsync(new DetailPage());

        //        return _selectedItem;
        //    }
        //    set
        //    {
        //        _selectedItem = value;

        //        //base.navigationService.SetMainPage("DetailPage");



        //        //base.navigationService.Navigate("DetailPage");

        //        //App.Navigator.PushAsync(new DetailPage());



        //        //App.Navigator.PushAsync(new DetailPage());
        //        //Application.Current.MainPage.Navigation.PushAsync(new DetailPage());

        //        //App.Navigator.PushAsync(new DetailPage());

        //        //navigationService.Navigate("DetailPage");


        //        //App.Navigator.PushAsync(new DetailPage());

        //        OnPropertyChanged();
        //    }
        //}

        //public void SearchOrdenVenta()
        //{
        //    IsBusy = true;

        //    var result = mascotaService.SearchOrdenVenta();

        //    Application.Current.Properties["ListOrdenVenta"] = result;

        //    IsBusy = false;
        //}

        //public ICommand RefreshCommand
        //{
        //    get { return _refreshCommand = _refreshCommand ?? new DelegateCommand<ProductoContratadoRef.ProductoContratadoAppList>(RefreshCommandExecute, RefreshCommandCanExecute); }
        //}

        //public bool RefreshCommandCanExecute(ProductoContratadoRef.ProductoContratadoAppList producto)
        //{
        //    if (!IsBusy && ProductosContratados.Count != 0 && ProductosContratados.Last().Id == producto.Id)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public void RefreshCommandExecute(ProductoContratadoRef.ProductoContratadoAppList producto)
        //{
        //    LoadItems();
        //}

        public ICommand GoToCommand { get { return new RelayCommand<string>(GoTo); } }

        private void GoTo(string pageName)
        {
            navigationService.Navigate(pageName);
        }

    }
}