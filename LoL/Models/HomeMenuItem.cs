using System;
using System.Collections.Generic;
using System.Text;

namespace LoL.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Signs
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
