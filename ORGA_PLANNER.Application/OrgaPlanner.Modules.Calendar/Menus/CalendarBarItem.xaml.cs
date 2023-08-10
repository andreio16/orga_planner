using BusinessCore.Interfaces;

using DevExpress.Xpf.Accordion;

namespace OrgaPlanner.Modules.Calendar.Menus
{
    /// <summary>
    /// Interaction logic for CalendarGroup.xaml
    /// </summary>
    public partial class CalendarBarItem : AccordionItem, IAccordionControlBar
    {
        public CalendarBarItem()
        {
            InitializeComponent();
        }

        public string DefaultNavigationPath => "Calendar";
    }
}
