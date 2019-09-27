using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using CiuchApp.Mobile.Models;
using CiuchApp.Mobile.ViewModels;
using CiuchApp.Domain;

namespace CiuchApp.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class BusinessTripDetailPage : ContentPage
    {
        BusinessTripViewModel viewModel;

        public BusinessTripDetailPage(BusinessTripViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        private async void Save_Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Sucess", "Saved", "Done");
        }
    }
}