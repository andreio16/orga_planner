using Prism.Mvvm;

namespace OrgaPlanner.Modules.Contacts.ViewModels
{
    public class ContactsPanelViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ContactsPanelViewModel()
        {
            Message = "View Contacts from your Prism Module";
        }
    }
}
