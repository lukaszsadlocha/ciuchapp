using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using CiuchApp.Mobile.Models;
using CiuchApp.Mobile.ViewModels;
using CiuchApp.Domain;
using Plugin.Media;

namespace CiuchApp.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class PieceDetailPage : ContentPage
    {
        BusinessTripDetailsViewModel viewModel;

        public PieceDetailPage(BusinessTripDetailsViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        private async void Save_Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Sucess", "Saved", "Done");
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

        private void Cancel_Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}