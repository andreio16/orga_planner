using BusinessCore.Interfaces;

using DevExpress.Xpf.Accordion;

namespace OrgaPlanner.Modules.Contacts.Menus
{
    /// <summary>
    /// Interaction logic for ContactsGroup.xaml
    /// </summary>
    public partial class ContactsBarItem : AccordionItem, IAccordionControlBar
    {
        public ContactsBarItem()
        {
            InitializeComponent();
        }

        public string DefaultNavigationPath => "Contacts";
    }
}
