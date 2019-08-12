using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinAppExpleShop.UIForms.ViewModel
{
    public class MainViewModel
    {
        public LoginViewModel Login { get; set; }

        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }

    }
}
