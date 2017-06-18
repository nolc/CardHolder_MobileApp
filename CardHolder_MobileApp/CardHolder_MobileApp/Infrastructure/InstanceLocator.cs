using CardHolder_MobileApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardHolder_MobileApp.Infrastructure
{
    public class InstanceLocator
    {
        public UsuarioViewModel User { get; set; }
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            User = new UsuarioViewModel();
            Main = new MainViewModel();
        }
    }
}