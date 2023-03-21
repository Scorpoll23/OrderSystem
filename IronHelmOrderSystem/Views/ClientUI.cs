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
    public partial class ClientUI : Form, IClientUI
    {
        public string ClientName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public string NumberOrName
        {
            get { return txtNumberOrName.Text; }
            set { txtNumberOrName.Text = value; }
        }

        public string AddressLine1
        {
            get { return txtAddressLine1.Text; }
            set { txtAddressLine1.Text = value; }
        }

        public string AddressLine2
        {
            get { return txtAddressLine2.Text; }
            set { txtAddressLine2.Text = value; }
        }

        public string Postcode
        {
            get { return txtPostcode.Text; }
            set { txtPostcode.Text = value; }
        }

        public string Country
        {
            get { return txtCountry.Text; }
            set { txtCountry.Text = value; }
        }

        private ClientPresenter presenter;

        public ClientUI()
        {
            InitializeComponent();
        }

        public void Register(ClientPresenter presenter)
        {
            this.presenter = presenter;
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClientName) ||
                string.IsNullOrEmpty(NumberOrName) ||
                string.IsNullOrEmpty(AddressLine1) ||
                string.IsNullOrEmpty(AddressLine2) ||
                string.IsNullOrEmpty(Postcode) ||
                string.IsNullOrEmpty(Country))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            if (Postcode.Length > 7)
            {
                MessageBox.Show("Postcode cannot be longer than 7 characters.");
                return;
            }

            presenter.SaveClient();

            Close();
        }
    }
}
