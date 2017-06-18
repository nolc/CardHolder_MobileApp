//using CardHolder_MobileApp.Model;
using CardHolder_MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CardHolder_MobileApp.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        //OrdenVentaModel mascotaService;

        public MainViewModel()
        {
            base.navigationService = new Services.NavigationService();

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
    }
}