using IronHelmOrderSystem.Entities;
using IronHelmOrderSystem.Models;
using IronHelmOrderSystem.Util;
using IronHelmOrderSystem.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronHelmOrderSystem.Presenters
{
    public class ClientListPresenter
    {
        private IClientListUI clientListUI;
        private IRepository repository;

        public ClientListPresenter(IClientListUI clientListUI, IRepository repository)
        {
            this.clientListUI = clientListUI;
            this.repository = repository;

            clientListUI.Register(this);
        }

        public void SetClientList()
        {
            List<Client> clients = repository.GetAllClients();

            DataTable clientsDataTable = new DataTable();
            clientsDataTable.Columns.Add("ClientID", typeof(int));
            clientsDataTable.Columns.Add("Name", typeof(string));
            clientsDataTable.Columns.Add("Number Or Name", typeof(string));
            clientsDataTable.Columns.Add("Address Line 1", typeof(string));
            clientsDataTable.Columns.Add("Address Line 2", typeof(string));
            clientsDataTable.Columns.Add("Postcode", typeof(string));
            clientsDataTable.Columns.Add("Country", typeof(string));

            foreach (var client in clients)
                clientsDataTable.LoadDataRow(new object[]
                {
                    client.ClientID,
                    client.Name,
                    client.NumberOrName,
                    client.AddressLine1,
                    client.AddressLine2,
                    client.Postcode,
                    client.Country
                }, false);

            clientListUI.SetClientList(clientsDataTable);
        }

        public void ShowEditClient(int clientID)
        {
            ClientUI clientUI = new ClientUI();
            ClientModel clientModel = new ClientModel(clientID);
            ClientPresenter clientPresenter = new ClientPresenter(clientModel, clientUI);
            clientUI.ShowDialog();

            //Refresh Client List.
            SetClientList();
        }
    }
}
