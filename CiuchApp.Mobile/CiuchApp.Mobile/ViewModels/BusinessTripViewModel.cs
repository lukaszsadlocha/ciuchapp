using System;
using CiuchApp.Domain;
using CiuchApp.Mobile.Models;

namespace CiuchApp.Mobile.ViewModels
{
    public class BusinessTripViewModel : BaseViewModel
    {
        public BusinessTrip Item { get; set; }
        public BusinessTripViewModel(BusinessTrip item = null)
        {
            Title = item?.Country?.Name;
            Item = item;
        }
    }
}
