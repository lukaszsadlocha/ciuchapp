using System;
using System.Collections.Generic;
using System.Text;

namespace CiuchApp.Mobile.Models
{
    public enum MenuItemType
    {
        BusinessTripsOverviewMenuType,
        PiecesOverviewMenuType,
        DropdownsOverviewMenuType,
        AccountMenuType,
        AboutMenuType
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
