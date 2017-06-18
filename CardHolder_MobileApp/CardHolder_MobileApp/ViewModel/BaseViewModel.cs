using CardHolder_MobileApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CardHolder_MobileApp.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        protected NavigationService navigationService;
        protected DialogService dialogService;

        #region Constructors
        public BaseViewModel()
        {
            navigationService = new NavigationService();
            dialogService = new DialogService();
        }
        #endregion

        private bool busy = false;

        public bool IsBusy
        {
            get { return busy; }
            set
            {
                if (busy == value)
                    return;

                busy = value;
                OnPropertyChanged();
            }
        }

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged = delegate
        {
        };

        public void OnPropertyChanged([CallerMemberName]string name = null)
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
