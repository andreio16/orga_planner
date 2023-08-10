using DevExpress.Xpf.Accordion;
using DevExpress.Xpf.Ribbon;
using ORGA_PLANNER.Application.Adaptors.RegionAdaptors;
using ORGA_PLANNER.Application.Views;
using OrgaPlanner.Modules.Calendar;
using OrgaPlanner.Modules.Contacts;
using OrgaPlanner.Modules.Navigation;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Windows;

namespace ORGA_PLANNER.Application
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ContactsModule>();
            moduleCatalog.AddModule<CalendarModule>();
            moduleCatalog.AddModule<NavigationModule>();
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            regionAdapterMappings.RegisterMapping(typeof(RibbonDefaultPageCategory), Container.Resolve<NavigationRibbonRegionAdapter>());
            regionAdapterMappings.RegisterMapping(typeof(AccordionControl), Container.Resolve<AccordionControlBarRegionAdapter>());
        }
    }
}
