using BusinessCore.Interfaces;

using DevExpress.Xpf.Accordion;

namespace OrgaPlanner.Modules.Contacts.Menus
{
    /// <summary>
    /// Interaction logic for ContactsGroup.xaml
    /// </summary>
    public partial class ContactsBar : AccordionItem, IAccordionControlBar
    {
        public ContactsBar()
        {
            InitializeComponent();
        }

        public string DefaultNavigationPath => "ContactsPanel";
    }
}
