using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinAppExpleShop.UIForms.ViewModel
{
    public class MainViewModel
    {

        private static MainViewModel Instance;




        public LoginViewModel Login { get; set; }

        public ProductsViewModel Products { get; set; }

        public  MainViewModel()
        {
            Instance = this;
            this.Login = new LoginViewModel();
        }

        public static MainViewModel GetInstance()
        {
            if (Instance == null)
            {
                return new MainViewModel();
            }
            return Instance;
        }

    }
}
