using BusinessCore.Interfaces;

using DevExpress.Xpf.Accordion;

namespace OrgaPlanner.Modules.Calendar.Menus
{
    /// <summary>
    /// Interaction logic for CalendarGroup.xaml
    /// </summary>
    public partial class CalendarBar : AccordionItem, IAccordionControlBar
    {
        public CalendarBar()
        {
            InitializeComponent();
        }

        public string DefaultNavigationPath => "ViewA";
    }
}
