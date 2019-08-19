using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinAppExpleShop.UIForms.Views;

namespace XamarinAppExpleShop.UIForms.ViewModel
{
    public class LoginViewModel
    {

        public LoginViewModel()
        {
            this.Email = "a";
            this.Password = "1";
        }

        public string Email { get; set; }
        public string Password { get; set; }

        public ICommand LoginCommand => new RelayCommand(Login);

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.
                    DisplayAlert("Error", "You most enter an email", "Accept");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.
                    DisplayAlert("Error", "You most enter a password", "Accept");
                return;
            }

            if (!this.Email.Equals("a")|| !this.Password.Equals("1"))
            {
                await Application.Current.MainPage.
                    DisplayAlert("Error", "User or Password incorrect", "Accept");
                return;
            }

            //await Application.Current.MainPage.
            // DisplayAlert("Ok", "Imgereso", "Accept");

            MainViewModel.GetInstance().Products = new ProductsViewModel();

            await Application.Current.MainPage.Navigation.PushAsync(new ProductsPage());
            
        }
    }
}
