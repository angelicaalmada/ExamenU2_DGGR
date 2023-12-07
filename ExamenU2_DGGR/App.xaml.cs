using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExamenU2_DGGR.Vista;

namespace ExamenU2_DGGR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Vcalorias();
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
