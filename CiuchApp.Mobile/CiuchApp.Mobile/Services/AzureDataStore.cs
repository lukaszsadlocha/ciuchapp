using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Essentials;
using CiuchApp.Mobile.Models;
using CiuchApp.Domain;

namespace CiuchApp.Mobile.Services
{
    public class AzureDataStore : IDataStore<BusinessTrip>
    {
        HttpClient client;
        IEnumerable<BusinessTrip> items;

        public AzureDataStore()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri($"{App.AzureBackendUrl}/");

            items = new List<BusinessTrip>();
        }

        bool IsConnected => Connectivity.NetworkAccess == NetworkAccess.Internet;
        public async Task<IEnumerable<BusinessTrip>> GetItemsAsync(bool forceRefresh = false)
        {
            if (forceRefresh && IsConnected)
            {
                try
                {
                    var json = await client.GetStringAsync($"businesstrips");
                    items = await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<BusinessTrip>>(json));
                }
                catch(Exception e)
                {
                    throw e;
                }
                
            }

            return items;
        }

        public async Task<BusinessTrip> GetItemAsync(string id)
        {
            if (id != null && IsConnected)
            {
                var json = await client.GetStringAsync($"api/businesstrips/{id}");
                return await Task.Run(() => JsonConvert.DeserializeObject<BusinessTrip>(json));
            }

            return null;
        }

        public async Task<bool> AddItemAsync(BusinessTrip item)
        {
            if (item == null || !IsConnected)
                return false;

            var serializedItem = JsonConvert.SerializeObject(item);

            var response = await client.PostAsync($"api/businesstrips", new StringContent(serializedItem, Encoding.UTF8, "application/json"));

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateItemAsync(BusinessTrip item)
        {
            if (item == null || !IsConnected)
                return false;

            var serializedItem = JsonConvert.SerializeObject(item);
            var buffer = Encoding.UTF8.GetBytes(serializedItem);
            var byteContent = new ByteArrayContent(buffer);

            var response = await client.PutAsync(new Uri($"api/businesstrips/{item.Id}"), byteContent);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            if (string.IsNullOrEmpty(id) && !IsConnected)
                return false;

            var response = await client.DeleteAsync($"api/businesstrips/{id}");

            return response.IsSuccessStatusCode;
        }
    }
}
