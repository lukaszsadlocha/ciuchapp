using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using CiuchApp.Mobile.Models;
using CiuchApp.Mobile.Views;
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json;
using CiuchApp.Domain;

namespace CiuchApp.Mobile.ViewModels
{
    public class BusinessTripOverviewViewModel : BaseViewModel
    {
        public ObservableCollection<BusinessTrip> BusinessTrips { get; set; }
        public Command LoadBusinessTripsCommand { get; set; }

        public BusinessTripOverviewViewModel()
        {
            Title = "CiuchApp - Wyjazdy";
            BusinessTrips = new ObservableCollection<BusinessTrip>();
            LoadBusinessTripsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<BusinessTripEditPage, BusinessTrip>(this, "Dodaj nowy", async (obj, item) =>
            {
                var newItem = item as BusinessTrip;
                BusinessTrips.Add(newItem);
                await BusinessTripDataStore.AddItemAsync(newItem);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                BusinessTrips.Clear();
                var items = await BusinessTripDataStore.GetItemsAsync(true);

                foreach (var item in items)
                {
                    BusinessTrips.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}