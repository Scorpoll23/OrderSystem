using IronHelmOrderSystem.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IronHelmOrderSystem.Views
{
    public partial class ClientListUI : Form, IClientListUI
    {
        private ClientListPresenter presenter;

        public ClientListUI()
        {
            InitializeComponent();

            dgClients.AllowUserToAddRows = false;
            dgClients.AllowUserToDeleteRows = false;
        }

        public void Register(ClientListPresenter presenter)
        {
            this.presenter = presenter;
        }

        public void SetClientList(DataTable clientList)
        {
            dgClients.DataSource = clientList;
            dgClients.AutoResizeColumns();

            //Set Columns as ReadOnly
            for (int i = 0; i < dgClients.ColumnCount; i++)
                dgClients.Columns[i].ReadOnly = true;

            // Add Edit Column
            if (dgClients.Columns["EditColumn"] == null)
                dgClients.Columns.Add(new DataGridViewButtonColumn() { Name = "EditColumn", Text = "Edit", HeaderText = "", UseColumnTextForButtonValue = true });
        }

        private void dgClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgClients.Rows[e.RowIndex];
            int clientID = (int)row.Cells[dgClients.Columns["ClientID"].Index].Value;

            if (e.ColumnIndex == dgClients.Columns["EditColumn"].Index)
                ShowEditClient(clientID);
        }

        private void ShowEditClient(int clientID)
        {
            presenter.ShowEditClient(clientID);
        }

        private void ClientListUI_Load(object sender, EventArgs e)
        {
            presenter.SetClientList();
        }
    }
}
