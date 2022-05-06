using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ApiPractica2.Views;
using ApiPractica2.Services;

namespace ApiPractica2
{
    public partial class App : Application
    {
        public static CatManager CatManager { get; set; }
        public App()
        {

            InitializeComponent();

            CatManager = new CatManager(new RestService());
            MainPage = new NavigationPage(new PussyListPage());
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
