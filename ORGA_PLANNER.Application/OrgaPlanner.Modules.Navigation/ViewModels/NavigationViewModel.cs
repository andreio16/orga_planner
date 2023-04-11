using Prism.Mvvm;

namespace OrgaPlanner.Modules.Navigation.ViewModels
{
    public class NavigationViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public NavigationViewModel()
        {
            Message = "Just a Prism Module";
        }
    }
}
