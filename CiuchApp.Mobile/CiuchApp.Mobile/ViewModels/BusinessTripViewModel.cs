using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CiuchApp.DataContext;
using CiuchApp.Domain;
using CiuchApp.Mobile.Models;

namespace CiuchApp.Mobile.ViewModels
{
    public class BusinessTripViewModel : BaseViewModel
    {
        public BusinessTrip Model { get; set; }

        public IEnumerable<City> Cities { get; set; }

        private City _selectedCity;

        public City SelectedCity
        {
            get => _selectedCity;
            set
            {
                _selectedCity = value;
                _someText = value.Name;
            }
        }



        public IEnumerable<Country> Countries { get; set; }
        public BusinessTripViewModel(BusinessTrip item = null)
        {
            Model = item;
            if (Model != null)
            {
                _dateFrom = Model.DateFrom;
                _dateTo = Model.DateTo;
                _someText = Model.Country?.Name;
                _inStock = true;
            }
            _someText = "Who wants to live forever?";

            //Task.Run(async () => await GetCountries());

            Cities = CiuchAppMockContext.Cities.ToList();
        }

        DateTime _dateFrom;
        DateTime _dateTo;
        string _someText;
        bool _inStock;

        public DateTime DateFrom
        {
            get => _dateFrom;
            set
            {
                _dateFrom = value;
                SetProperty(ref _dateFrom, value);
            }
        }
        public DateTime DateTo
        {
            get => _dateTo;
            set
            {
                _dateTo = value;
                SetProperty(ref _dateTo, value);
            }
        }
        public string SomeText
        {
            get => _someText;
            set
            {
                _someText = value;
                SetProperty(ref _someText, value);
            }
        }

        public bool InStock
        {
            get => _inStock;
            set
            {
                _inStock = value;
                SetProperty(ref _inStock, value);
            }
        }

        private string _imageUrl;

        public string ImageUrl
        {
            get => _imageUrl;
            set
            {
                _imageUrl = value;
                SetProperty(ref _imageUrl, value);
            }
        }

    }
}
