using CiuchApp.Mobile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CiuchApp.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }

        readonly List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.BusinessTripsOverviewMenuType, Title="Wyjazdy" },
                new HomeMenuItem {Id = MenuItemType.PiecesOverviewMenuType, Title="Ciuchy" },
                new HomeMenuItem {Id = MenuItemType.DropdownsOverviewMenuType, Title="Wartości" },
                new HomeMenuItem {Id = MenuItemType.AccountMenuType, Title="Konto" },
                new HomeMenuItem {Id = MenuItemType.AboutMenuType, Title="O aplikacji" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}