using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using CiuchApp.Mobile.Models;
using CiuchApp.Mobile.ViewModels;
using CiuchApp.Domain;
using System.Linq;

namespace CiuchApp.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class BusinessTripDetailPage : ContentPage
    {
        BusinessTripDetailsViewModel viewModel;

        public BusinessTripDetailPage(BusinessTripDetailsViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await viewModel.GetPickerValues();
        }

        private async void Save_Button_Clicked(object sender, EventArgs e)
        {
            IsBusy = true;
            await viewModel.Save();
            await DisplayAlert("", "Zmiany zostały zapisane", "Wróć");
        }

        private void Cancel_Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}