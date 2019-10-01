using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using CiuchApp.Mobile.Models;
using CiuchApp.Mobile.Views;
using CiuchApp.Mobile.ViewModels;
using CiuchApp.Domain;
using Plugin.Media;

namespace CiuchApp.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class BusinessTripOverviewPage : ContentPage
    {
        BusinessTripOverviewViewModel viewModel;

        public BusinessTripOverviewPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new BusinessTripOverviewViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as BusinessTrip;
            if (item == null)
                return;

            await Navigation.PushAsync(new BusinessTripDetailPage(new BusinessTripDetailsViewModel(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new BusinessTripEditPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.BusinessTrips.Count == 0)
                viewModel.LoadBusinessTripsCommand.Execute(null);
        }

      
    }
}