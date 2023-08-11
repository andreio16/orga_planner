using BusinessCore;

using OrgaPlanner.Modules.Calendar.Menus;
using OrgaPlanner.Modules.Calendar.ViewModels;
using OrgaPlanner.Modules.Calendar.Views;

using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
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
            //_regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(ViewA));
            _regionManager.RegisterViewWithRegion(RegionNames.BarRegion, typeof(CalendarBar));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<CalendarBar, CalendarBarViewModel>();

            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
        }
        #endregion
    }
}