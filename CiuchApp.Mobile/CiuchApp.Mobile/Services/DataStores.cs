using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Essentials;
using CiuchApp.Mobile.Models;
using CiuchApp.Domain;
using System.Linq;
using System.Diagnostics;

namespace CiuchApp.Mobile.Services
{
    public class BusinessTripDataStorage : DataStore<BusinessTrip>, IDataStore<BusinessTrip>
    {
        public override string EndpointName => "businesstrips";
    }

    public class CountryDataStorage : DataStore<Country>, IDataStore<Country>
    {
        public override string EndpointName => "countries";
    }

    public class CityDataStorage : DataStore<City>, IDataStore<City>
    {
        public override string EndpointName => "cities";
    }

    public class SeasonTripDataStorage : DataStore<Season>, IDataStore<Season>
    {
        public override string EndpointName => "seasons";
    }

    public class CurrencyTripDataStorage : DataStore<Currency>, IDataStore<Currency>
    {
        public override string EndpointName => "currencies";
    }

    public abstract class DataStore<T> where T : CiuchAppBaseModel
    {

        public virtual string EndpointName { get; set; }

        HttpClient client;

        public DataStore()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri($"{App.AzureBackendUrl}/");
        }

        bool IsConnected => Connectivity.NetworkAccess == NetworkAccess.Internet;

        public async Task<IList<T>> GetItemsAsync(bool forceRefresh = true)
        {
            if (forceRefresh && IsConnected)
            {
                try
                {
                    var json = await client.GetStringAsync(EndpointName);
                    return await Task.Run(() => JsonConvert.DeserializeObject<List<T>>(json));

                }
                catch (Exception e)
                {
                    throw e;
                }

            }
            return new List<T>();
        }

        public async Task<T> GetItemAsync(string id)
        {
            if (id != null && IsConnected)
            {
                var json = await client.GetStringAsync($"{EndpointName}/{id}");
                return await Task.Run(() => JsonConvert.DeserializeObject<T>(json));
            }

            return default(T);
        }

        public async Task<bool> AddItemAsync(T item)
        {
            if (item == null || !IsConnected)
                return false;

            var serializedItem = JsonConvert.SerializeObject(item);

            var response = await client.PostAsync(EndpointName, new StringContent(serializedItem, Encoding.UTF8, "application/json"));

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateItemAsync(T item)
        {
            if (item == null || !IsConnected)
                return false;

            var serializedItem = JsonConvert.SerializeObject(item);
            var buffer = Encoding.UTF8.GetBytes(serializedItem);
            var byteContent = new ByteArrayContent(buffer);

            var response = await client.PutAsync(new Uri($"{EndpointName}/{item.Id}"), byteContent);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            if (string.IsNullOrEmpty(id) && !IsConnected)
                return false;

            var response = await client.DeleteAsync($"{EndpointName}/{id}");

            return response.IsSuccessStatusCode;
        }
    }
}
