using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

using CiuchApp.Mobile.Models;
using CiuchApp.Mobile.Services;
using CiuchApp.Domain;

namespace CiuchApp.Mobile.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public IDataStore<BusinessTrip> BusinessTripDataStore => DependencyService.Get<IDataStore<BusinessTrip>>();
        public IDataStore<Country> CountryDataStore => DependencyService.Get<IDataStore<Country>>();
        public IDataStore<City> CityDataStore => DependencyService.Get<IDataStore<City>>();
        public IDataStore<Season> SeasonDataStore => DependencyService.Get<IDataStore<Season>>();
        public IDataStore<Currency> CurrencyDataStore => DependencyService.Get<IDataStore<Currency>>();


        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName]string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
