using BusinessCore.Factories;
using BusinessCore.Models;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Windows.Documents;

namespace OrgaPlanner.Modules.Contacts.ViewModels
{
    public class ContactsPanelViewModel : BindableBase
    {
        #region Fields

        private bool areClientsActive;

        private List<ClientDTO> clients;

        #endregion

        #region Properties

        public bool ClientsActiveStatus
        {
            get { return areClientsActive; }
            set { SetProperty(ref this.areClientsActive, value); }
        }

        public List<ClientDTO> Clients 
        { 
            get { return clients; }
            set { SetProperty(ref this.clients, value); }
        }

        #endregion

        #region Constructor

        public ContactsPanelViewModel()
        {
            areClientsActive = true;
            clients = ClientFactory.GetClientList();
        }

        #endregion

        #region Methods

        #endregion
    }
}
