using BusinessCore;
using OrgaPlanner.Modules.Navigation.Menus;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace OrgaPlanner.Modules.Navigation
{
    public class NavigationModule : IModule
    {
        #region Fields
        private readonly IRegionManager _regionManager;
        #endregion

        #region Constructors
        public NavigationModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        #endregion

        #region Methods
        public void OnInitialized(IContainerProvider containerProvider)
        {
            // Only use this for static appearance on the UI - View Discovery
            _regionManager.RegisterViewWithRegion(RegionNames.RibbonRegion, typeof(HomeTabView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
        #endregion
    }
}