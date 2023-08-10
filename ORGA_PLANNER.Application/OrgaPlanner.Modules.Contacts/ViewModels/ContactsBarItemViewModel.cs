using BusinessCore.Models;

using Prism.Mvvm;

using System.Collections.ObjectModel;

namespace OrgaPlanner.Modules.Contacts.ViewModels
{
    public class ContactsBarItemViewModel : BindableBase
    {
        #region Fiels
        private ObservableCollection<NavigationItem> _items;
        #endregion

        #region Properties
        public ObservableCollection<NavigationItem> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }
        #endregion

        #region Constructor
        public ContactsBarItemViewModel()
        {
            Items = new ObservableCollection<NavigationItem>();

            Items.Add(new NavigationItem() { Caption = "Clients", NavigationPath = "" });
            Items.Add(new NavigationItem() { Caption = "Employee", NavigationPath = "" });
            Items.Add(new NavigationItem() { Caption = "Providers", NavigationPath = "" });

        }
        #endregion





    }
}
