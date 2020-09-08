using System;
using xa.Turno.App.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xa.Turno.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ListadoPage();
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
