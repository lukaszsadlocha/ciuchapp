using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CiuchApp.DataContext;
using CiuchApp.Domain;
using CiuchApp.Mobile.Models;
using CiuchApp.Mobile.Services;
using Xamarin.Forms;

namespace CiuchApp.Mobile.ViewModels
{
    public class BusinessTripDetailsViewModel : BaseViewModel
    {
        public BusinessTrip Model { get; set; }

        public ObservableCollection<Country> Countries { get; set; }
        public Command LoadCountriesCommand { get; set; }

        public ObservableCollection<City> Cities { get; set; }
        public Command LoadCitiesCommand { get; set; }

        public Command InitializeCityCommand { get; set; }

        public ObservableCollection<Season> Seasons { get; set; }
        public Task LoadSeasonsTask { get; set; }

        public ObservableCollection<Currency> Currencies { get; set; }
        public Command LoadCurrenciesCommand { get; set; }


        Country selectedCountry;

        internal async Task Save()
        {
            await BusinessTripDataStore.UpdateItemAsync(Model);
        }

        public Country SelectedCountry
        {
            get { return selectedCountry; }
            set
            {
                Model.Country = value;
                Model.CountryId = Model.Country.Id;
                SetProperty(ref selectedCountry, value);
            }
        }

        City selectedCity;
        public City SelectedCity
        {
            get { return selectedCity; }
            set
            {
                Model.City = value;
                Model.CityId = Model.City.Id;
                SetProperty(ref selectedCity, value);
            }
        }

        Season selectedSeason;
        public Season SelectedSeason
        {
            get { return selectedSeason; }
            set
            {
                Model.Season = value;
                Model.SeasonId = Model.Season.Id;
                SetProperty(ref selectedSeason, value);
            }
        }

        Currency selectedCurrency;
        public Currency SelectedCurrency
        {
            get { return selectedCurrency; }
            set
            {
                Model.Currency = value;
                Model.CurrencyId = Model.Currency.Id;
                SetProperty(ref selectedCurrency, value);
            }
        }


        public BusinessTripDetailsViewModel(BusinessTrip item = null)
        {
            IsBusy = true;
            Model = item ?? new BusinessTrip();

            Countries = new ObservableCollection<Country>();
            Cities = new ObservableCollection<City>();
            Seasons = new ObservableCollection<Season>();
            Currencies = new ObservableCollection<Currency>();
        }



        public async Task GetPickerValues()
        {
            var countriesList = await CountryDataStore.GetItemsAsync();

            foreach (Country c in countriesList)
            {
                Countries.Add(c);
            }

            SelectedCountry = Countries.First(x => x.Id == Model.Country.Id);


            var citiesList = await CityDataStore.GetItemsAsync();
            foreach (var item in citiesList)
            {
                Cities.Add(item);
            }

            SelectedCity = Cities.First(x => x.Id == Model.City.Id);

            
            var seasonsList = await SeasonDataStore.GetItemsAsync();
            foreach (var item in seasonsList)
            {
                Seasons.Add(item);
            }
            
            SelectedSeason = Seasons.First(x => x.Id == Model.Season.Id);


            var currenciesList = await CurrencyDataStore.GetItemsAsync();
            foreach (var item in currenciesList)
            {
                Currencies.Add(item);
            }

            SelectedCurrency = Currencies.First(x => x.Id == Model.Currency.Id);

            IsBusy = false;
        }

        async Task ExecuteLoadItemsCommand<T>(ObservableCollection<T> collection, IDataStore<T> dataStore)
        {
            //if (IsBusy)
            //    return;

            //IsBusy = true;

            try
            {
                collection.Clear();
                var items = await dataStore.GetItemsAsync(true);

                foreach (var item in items)
                {
                    collection.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            //finally
            //{
            //    IsBusy = false;
            //}
        }


        //DateTime _dateFrom;
        //DateTime _dateTo;
        //string _someText;
        //bool _inStock;

        //public DateTime DateFrom
        //{
        //    get => _dateFrom;
        //    set
        //    {
        //        _dateFrom = value;
        //        SetProperty(ref _dateFrom, value);
        //    }
        //}
        //public DateTime DateTo
        //{
        //    get => _dateTo;
        //    set
        //    {
        //        _dateTo = value;
        //        SetProperty(ref _dateTo, value);
        //    }
        //}
        //public string SomeText
        //{
        //    get => _someText;
        //    set
        //    {
        //        _someText = value;
        //        SetProperty(ref _someText, value);
        //    }
        //}

        //public bool InStock
        //{
        //    get => _inStock;
        //    set
        //    {
        //        _inStock = value;
        //        SetProperty(ref _inStock, value);
        //    }
        //}

        //private string _imageUrl;

        //public string ImageUrl
        //{
        //    get => _imageUrl;
        //    set
        //    {
        //        _imageUrl = value;
        //        SetProperty(ref _imageUrl, value);
        //    }
        //}

    }
}
