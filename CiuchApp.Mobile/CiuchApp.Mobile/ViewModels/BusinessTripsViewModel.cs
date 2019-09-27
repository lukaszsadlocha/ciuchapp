﻿using System;
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
    public class BusinessTripsViewModel : BaseViewModel
    {
        public ObservableCollection<BusinessTrip> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public BusinessTripsViewModel()
        {
            Title = "Browse";
            Items = new ObservableCollection<BusinessTrip>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewItemPage, BusinessTrip>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item as BusinessTrip;
                Items.Add(newItem);
                await DataStore.AddItemAsync(newItem);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);

                foreach (var item in items)
                {
                    Items.Add(item);
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

        async Task<IEnumerable<BusinessTrip>> LoadCiuchApp()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var responseString = "";
                try
                {
                    responseString = await httpClient.GetStringAsync(@"http://ciuchapp.lukaszsadlocha.pl/api/businesstrips");
                }
                catch (Exception e)
                {
                    throw e;
                }

                if (string.IsNullOrEmpty(responseString))
                {
                    return new List<BusinessTrip>();
                }

                return JsonConvert.DeserializeObject<IEnumerable<BusinessTrip>>(responseString);

            }


        }

    }
}