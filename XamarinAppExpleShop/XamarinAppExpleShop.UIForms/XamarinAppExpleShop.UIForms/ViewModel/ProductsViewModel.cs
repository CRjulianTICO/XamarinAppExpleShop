


namespace XamarinAppExpleShop.UIForms.ViewModel
{

    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;
    using Xamarin.Forms;
    using XamarinAppExpleShop.Common.Models;
    using XamarinAppExpleShop.Common.Services;

    public class ProductsViewModel : BaseViewModel
    {

        private ApiService apiService;

        private ObservableCollection<Product> products;

        private bool isRefreshing;

        public ObservableCollection<Product> Products
        {
            get { return this.products; }
            set { this.SetValue(ref this.products, value); }
        }


        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { this.SetValue(ref this.isRefreshing, value); }
        }




        public ProductsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadProducts();
            
        }




        private async void LoadProducts()
        {
            this.IsRefreshing = true;
            var response = await this.apiService.GetListAsync<Product>("https://xaesw.azurewebsites.net","/API","/Products");

            this.IsRefreshing = false;

            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("Error",response.Message,"Aceptar");
                return;
            }

            var myProducts = (List<Product>)response.Result;
            this.Products = new ObservableCollection<Product>(myProducts);

            

        }

        
    }
}
