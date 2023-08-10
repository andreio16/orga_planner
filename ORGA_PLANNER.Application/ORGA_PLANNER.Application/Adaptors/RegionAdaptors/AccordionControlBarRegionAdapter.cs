using DevExpress.Xpf.Accordion;

using Prism.Regions;

using System;
using System.Collections.Specialized;
using System.Windows;

namespace ORGA_PLANNER.Application.Adaptors.RegionAdaptors
{
    public class AccordionControlBarRegionAdapter : RegionAdapterBase<AccordionControl>
    {
        #region Constructor
        public AccordionControlBarRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory) : base(regionBehaviorFactory)
        {
        }
        #endregion

        #region Methods

        protected override void Adapt(IRegion region, AccordionControl regionTarget)
        {
            if (region == null) throw new ArgumentNullException(nameof(region));
            if (regionTarget == null) throw new ArgumentNullException(nameof(regionTarget));

            region.Views.CollectionChanged += (sender, args) =>
            {
                if (args.Action == NotifyCollectionChangedAction.Add)
                {
                    foreach (FrameworkElement view in args.NewItems)
                        regionTarget.Items.Add(view);
                }
                if (args.Action == NotifyCollectionChangedAction.Remove)
                {
                    foreach (FrameworkElement view in args.NewItems)
                        regionTarget.Items.Remove(view);
                }
            };
        }

        protected override IRegion CreateRegion()
        {
            return new SingleActiveRegion();
        }
        #endregion
    }
}
