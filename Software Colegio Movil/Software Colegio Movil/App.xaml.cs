using Software_Colegio_Movil.Services;
using Software_Colegio_Movil.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Software_Colegio_Movil
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
