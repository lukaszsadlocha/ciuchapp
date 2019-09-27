using System;
using CiuchApp.Domain;
using CiuchApp.Mobile.Models;

namespace CiuchApp.Mobile.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public BusinessTrip Item { get; set; }
        public ItemDetailViewModel(BusinessTrip item = null)
        {
            Title = item?.Country?.Name;
            Item = item;
        }
    }
}
