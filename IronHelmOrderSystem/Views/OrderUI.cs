using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronHelmOrderSystem.Presenters;
using IronHelmOrderSystem.Views;

namespace IronHelmOrderSystem.Views
{
    public partial class OrderUI : Form, IOrderUI
    {
        private OrderPresenter presenter;

        public new string Name {
            get { return txtOrderName.Text; }
            set { txtOrderName.Text = value; }
        }

        public OrderUI()
        {
            InitializeComponent();
        }

        public void Register(OrderPresenter presenter)
        {
            this.presenter = presenter;
        }

        private void NewEnquiry_Load(object sender, EventArgs e)
        {
            SetExistingCustomerInput(false);
        }

        private void btn_radioNewCustomer_CheckedChanged(object sender, EventArgs e)
        {
            SetNewCustomerInput(true);
            SetExistingCustomerInput(false);
        }

        private void btn_radioExistingCustomer_CheckedChanged(object sender, EventArgs e)
        {
            SetNewCustomerInput(false);
            SetExistingCustomerInput(true);
        }

        private void SetNewCustomerInput(bool _value)
        {
            txt_customerName.Enabled = _value;
            txt_homeNameNumber.Enabled = _value;
            txt_address1.Enabled = _value;
            txt_address2.Enabled = _value;
            txt_postcode.Enabled = _value;
            txt_country.Enabled = _value;
        }

        private void SetExistingCustomerInput(bool _value)
        {
            cmb_existingCustomerName.Enabled = _value;
            txt_existingHomeNameNumber.Enabled = _value;
            txt_existingAddress1.Enabled = _value;
            txt_existingAddress2.Enabled = _value;
            txt_existingPostcode.Enabled = _value;
            txt_existingCountry.Enabled = _value;
        }

        private void btn_uploadImage_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pbx_uploadedImage.ImageLocation = imageLocation;
                    pbx_uploadedImage.SizeMode = PictureBoxSizeMode.StretchImage;

                }
            } catch
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
