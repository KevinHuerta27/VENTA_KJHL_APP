using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VENTA_KJHL_APP.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VENTA_KJHL_APP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            MainPage = new NavigationPage(new DispositivosPage());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
