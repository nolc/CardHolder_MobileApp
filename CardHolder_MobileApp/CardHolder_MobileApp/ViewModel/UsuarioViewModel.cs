//using CardHolder_MobileApp.Model;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CardHolder_MobileApp.ViewModel
{
    public class UsuarioViewModel : BaseViewModel
    {
        //OrdenVentaModel mascotaService;

        #region Properties
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }
        #endregion

        public UsuarioViewModel()
        {
           /// mascotaService = new OrdenVentaModel();
        }

        #region Methods

        public ICommand StartCommand
        {
            get { return new RelayCommand(Start); }
        }

        private void Start()
        {
            try
            {
                //IsBusy = true;

                //TODO:
                this.Usuario = "smoreno";
                this.Contrasenia = "123";

                this.SearchOrdenVenta();

                base.navigationService.SetMainPage("MasterPage");

                

                //Navigation

                //App.Current.  Navigation.PushAsync(nextPage);

                //await App.Navigator.PushAsync(new );

                //var result = await userService.ValidateUsuario(this.Usuario, this.Contrasenia);

                //IsBusy = false;

                //if (result.IsComplete)
                //{

                //    Application.Current.Properties["User"] = result.RecordId;

                //    base.navigationService.SetMainPage("MasterPage");

                //}
                //else
                //{
                //    await base.dialogService.ShowMessage("La cuenta de usuario o contraseña o ambas son inconrrectas.", "Acceso inválido");
                //}
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SearchOrdenVenta()
        {
            IsBusy = true;

            //var result = mascotaService.SearchOrdenVenta();

            //Application.Current.Properties["ListOrdenVenta"] = result;

            IsBusy = false;
        }

        #endregion

    }
}
