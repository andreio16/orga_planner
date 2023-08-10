using BusinessCore;

using OrgaPlanner.Modules.Contacts.Menus;
using OrgaPlanner.Modules.Contacts.ViewModels;

using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;

namespace OrgaPlanner.Modules.Contacts
{
    public class ContactsModule : IModule
    {
        #region Fields
        private readonly IRegionManager _regionManager;
        #endregion

        #region Constructors
        public ContactsModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        #endregion

        #region Methods
        public void OnInitialized(IContainerProvider containerProvider)
        {
            //_regionManager.RegisterViewWithRegion(RegionNames.PlannerGroupRegion, typeof(ContactsPanel));
            _regionManager.RegisterViewWithRegion(RegionNames.BarRegion, typeof(ContactsBarItem));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<ContactsBarItem, ContactsBarItemViewModel>();
        }
        #endregion
    }
}