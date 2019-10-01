using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CiuchApp.Mobile.Services;
using CiuchApp.Mobile.Views;

namespace CiuchApp.Mobile
{
    public partial class App : Application
    {
        public static string AzureBackendUrl = "https://api.ciuchapp.lukaszsadlocha.pl";
            
        public App()
        {
            InitializeComponent();
            DependencyService.Register<BusinessTripDataStorage>();
            DependencyService.Register<CountryDataStorage>();
            DependencyService.Register<CityDataStorage>();
            DependencyService.Register<SeasonTripDataStorage>();
            DependencyService.Register<CurrencyTripDataStorage>();


            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
