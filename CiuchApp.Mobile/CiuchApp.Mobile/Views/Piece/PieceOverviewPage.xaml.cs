using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using CiuchApp.Mobile.Models;
using CiuchApp.Mobile.Views;
using CiuchApp.Mobile.ViewModels;
using CiuchApp.Domain;
using Plugin.Media;

namespace CiuchApp.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class PieceOverviewPage : ContentPage
    {
        PieceOverviewViewModel viewModel;

        public PieceOverviewPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new PieceOverviewViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as BusinessTrip;
            if (item == null)
                return;

            await Navigation.PushAsync(new BusinessTripDetailPage(new BusinessTripDetailsViewModel(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new BusinessTripEditPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Pieces.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }

        private async void TakePictureButton_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                DisplayAlert("No Camera", ":( No camera available.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                SaveToAlbum = true
                // Save to album or Directory / name
                //Directory = "Sample",
                //Name = "test.jpg"
            });

            if (file == null)
                return;

            PathLabel.Text = file.AlbumPath;

            await DisplayAlert("File Location", file.Path, "OK");

            MyImage.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });

        }
    }
}