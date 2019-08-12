using System;
using System.Collections.Generic;
using System.Text;
using XamarinAppExpleShop.UIForms.ViewModel;

namespace XamarinAppExpleShop.UIForms.Infrastructure
{
    public class InstanceLocator
    {

        public MainViewModel Main { get; set; }


        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }

    }
}
