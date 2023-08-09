using BusinessCore.Factories;
using BusinessCore.Models.DTOs;
using Prism.Commands;
using Prism.Mvvm;

using System.Collections.Generic;
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

        public DelegateCommand RefreshCommand { get; private set; }

        public DelegateCommand ActivationStatusCommand { get; private set; }

        #endregion

        #region Constructor

        public ContactsPanelViewModel()
        {
            InitializeProperties();
            InitializeEvents(); 
            InitializeCommands();
        }

        #endregion

        #region Methods

        public void InitializeProperties()
        {
            clients = new ObservableCollection<ClientDTO>(FetchCoreClients());
            clientsCollectionViewSource = new CollectionViewSource();

            clientsCollectionViewSource.Source = clients;
            areClientsActive = true;
        }

        public void InitializeCommands()
        {
            this.SearchCommand = new DelegateCommand(this.OnSearch);
            this.RefreshCommand = new DelegateCommand(this.OnRefresh);
            this.ActivationStatusCommand = new DelegateCommand(this.OnActivationStatus).ObservesProperty(() => ClientsActiveStatus);
        }

        public void InitializeEvents()
        {
            clientsCollectionViewSource.Filter += CollectionViewSource_FilterActiveClientsByFirstName;
        }

        private void CollectionViewSource_FilterActiveClientsByFirstName(object sender, FilterEventArgs e)
        {
            ClientDTO client = e.Item as ClientDTO;

            if (string.IsNullOrEmpty(FilterText))
            {
                _ = (client.isActive) ? e.Accepted = true : e.Accepted = false;
                return;
            }

            if (client != null) 
            {

                if (client.FirstName.ToUpper().Contains(FilterText.ToUpper()) && client.isActive)
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }

        private void CollectionViewSource_FilterInactiveClientsByFirstName(object sender, FilterEventArgs e)
        {
            ClientDTO client = e.Item as ClientDTO;

            if (string.IsNullOrEmpty(FilterText))
            {
                _ = (!client.isActive) ? e.Accepted = true : e.Accepted = false;
                return;
            }

            if (client != null)
            {

                if (client.FirstName.ToUpper().Contains(FilterText.ToUpper()) && !client.isActive)
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }

        private void OnSearch()
        {
            this.clientsCollectionViewSource.View.Refresh();
        }

        private void OnRefresh()
        {
            filterText = string.Empty;
            this.FilterText = filterText;   
            this.clientsCollectionViewSource.View.Refresh();
        }

        private void OnActivationStatus()
        {
            if (areClientsActive)
            {
                clientsCollectionViewSource.Filter -= CollectionViewSource_FilterInactiveClientsByFirstName;
                clientsCollectionViewSource.Filter += CollectionViewSource_FilterActiveClientsByFirstName;
            }
            else
            {
                clientsCollectionViewSource.Filter -= CollectionViewSource_FilterActiveClientsByFirstName;
                clientsCollectionViewSource.Filter += CollectionViewSource_FilterInactiveClientsByFirstName;
            }

            this.clientsCollectionViewSource.View.Refresh();
        }

        private IEnumerable<ClientDTO> FetchCoreClients()
        {
            CoreFactory core = new CoreFactory();
            return core.GetClients();
        }

        #endregion
    }
}
