using CiuchApp.Domain;
using CiuchApp.Mobile.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CiuchApp.Mobile.Views
{
    internal class PieceOverviewViewModel
    {
        public ObservableCollection<BusinessTrip> Pieces { get; set; }
        public Command LoadItemsCommand { get; set; }
    }
}