using BusinessCore;    
using OrgaPlanner.Modules.Contacts.Views;
using Prism.Ioc;
using Prism.Modularity;
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
            _regionManager.RegisterViewWithRegion(RegionNames.ContactsRegion, typeof(ContactsPanel));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
        #endregion
    }
}