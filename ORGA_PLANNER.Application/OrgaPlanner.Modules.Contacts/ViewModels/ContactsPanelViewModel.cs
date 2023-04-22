using BusinessCore.Factories;
using BusinessCore.Models;
using Prism.Mvvm;
using Prism.Commands;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;

namespace OrgaPlanner.Modules.Contacts.ViewModels
{
    public class ContactsPanelViewModel : BindableBase
    {
        #region Fields

        private bool areClientsActive;

        private string filterText;

        private ObservableCollection<ClientDTO> clients;

        private CollectionViewSource clientsCollectionViewSource;

        #endregion

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Properties

        public bool ClientsActiveStatus
        {
            get { return this.areClientsActive; }
            set { SetProperty(ref this.areClientsActive, value); }
        }

        public string FilterText
        {
            get { return this.filterText; }
            set 
            {
                filterText = value;
                this.clientsCollectionViewSource.View.Refresh();
                RaisePropertyChanged(nameof(FilterText));
            }
        }

        public ObservableCollection<ClientDTO> Clients
        {
            get { return this.clients; }
            set { SetProperty(ref this.clients, value); }
        }

        public ICollectionView ClientsCollectionViewSource 
        {
            get{ return this.clientsCollectionViewSource.View; }
        }

        public DelegateCommand SearchCommand { get; private set; }

        #endregion

        #region Constructor

        public ContactsPanelViewModel()
        {
            clients =  new ObservableCollection<ClientDTO>(ClientFactory.GetClientList());
            areClientsActive = true;
            clientsCollectionViewSource = new CollectionViewSource();
            clientsCollectionViewSource.Source = clients;
            clientsCollectionViewSource.Filter += ClientsCollectionViewSource_Filter;
        }

        #endregion

        #region Methods

        public void InitializeProperties()
        {

        }

        public void InitializeCommands()
        {
            this.SearchCommand = new DelegateCommand(this.OnSearch);
        }

        public void InitializeEvents()
        {

        }

        public void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void OnSearch()
        {
        }

        private void ClientsCollectionViewSource_Filter(object sender, FilterEventArgs e)
        {
            if (string.IsNullOrEmpty(FilterText))
            {
                e.Accepted = true;
                return;
            }

            ClientDTO client = e.Item as ClientDTO;
            if (client.FirstName.ToUpper().Contains(FilterText.ToUpper()))
            {
                e.Accepted = true;
            }
            else
            {
                e.Accepted = false;
            }
        }
        #endregion
    }
}
