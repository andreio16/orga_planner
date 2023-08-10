using BusinessCore;

using OrgaPlanner.Modules.Calendar.Menus;
using OrgaPlanner.Modules.Calendar.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace OrgaPlanner.Modules.Calendar
{
    public class CalendarModule : IModule
    {
        #region Fields
        private readonly IRegionManager _regionManager;
        #endregion

        #region Constructors
        public CalendarModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        #endregion

        #region Methods
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(ViewA));
            _regionManager.RegisterViewWithRegion(RegionNames.BarRegion, typeof(CalendarBarItem));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
        #endregion
    }
}