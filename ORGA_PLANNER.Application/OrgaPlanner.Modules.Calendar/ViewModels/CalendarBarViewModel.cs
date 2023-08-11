using BusinessCore.Models;
using Prism.Mvvm;

using System.Collections.ObjectModel;

namespace OrgaPlanner.Modules.Calendar.ViewModels
{
    public class CalendarBarViewModel : BindableBase
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
        public CalendarBarViewModel()
        {
            GenerateMenu();
        }
        #endregion

        #region Methods
        private void GenerateMenu()
        {
            Items = new ObservableCollection<NavigationItem>();
            Items.Add(new NavigationItem() { Caption = "Appointments", NavigationPath = "" });
        }
        #endregion
    }
}
