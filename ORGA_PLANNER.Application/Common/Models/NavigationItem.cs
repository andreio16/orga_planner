﻿using System.Collections.ObjectModel;

namespace BusinessCore.Models
{
    public class NavigationItem
    {
        public string? Caption { get; set; }
        public string? NavigationPath { get; set; }
        public ObservableCollection<NavigationItem>? Items { get; set; }

        public NavigationItem()
        {
            Items = new ObservableCollection<NavigationItem>();
        }
    }
}
