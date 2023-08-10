using DevExpress.Xpf.Ribbon;

using Prism.Regions;

using System;

namespace ORGA_PLANNER.Application.Adaptors.RegionAdaptors
{
    public class NavigationRibbonRegionAdapter : RegionAdapterBase<RibbonDefaultPageCategory>
    {
        #region Constructor
        public NavigationRibbonRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory) 
            : base(regionBehaviorFactory)
        {
        }
        #endregion

        #region Methods
        protected override void Adapt(IRegion region, RibbonDefaultPageCategory regionTarget)
        {
            if (region == null) throw new ArgumentNullException(nameof(region));
            if (regionTarget == null) throw new ArgumentNullException(nameof(regionTarget));

            region.Views.CollectionChanged += (sender, args) =>
            {
                if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                {
                    foreach (RibbonPage page in region.Views)
                        regionTarget.Pages.Add(page);
                }  
                if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
                {
                    foreach (RibbonPage page in region.Views)
                        regionTarget.Pages.Remove(page);
                }
            };
        }

        protected override IRegion CreateRegion()
        {
            // Single active region : Prism is keeping track of the active controll
            // Good for a ribbonControl/Menu when a tab should be active at a time
            return new SingleActiveRegion();
        }

        #endregion
    }
}
