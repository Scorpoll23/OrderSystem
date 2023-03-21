using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronHelmOrderSystem.Presenters;

namespace IronHelmOrderSystem.Views
{
    public partial class OrderListUI : Form, IOrderListUI
    {
        private OrderListPresenter presenter;

        public OrderListUI()
        {
            InitializeComponent();

            dgClientOrders.AllowUserToAddRows = false;
            dgClientOrders.AllowUserToDeleteRows = false;

            // Order Table

        }

        public void Register(OrderListPresenter presenter)
        {
            this.presenter = presenter;
        }

        public void SetClientList(Dictionary<int, string> source)
        {
            cmbCustomerNames.DataSource = new BindingSource(source, null);
            cmbCustomerNames.DisplayMember = "Value";
            cmbCustomerNames.ValueMember = "Key";
        }

        public void SetOrderList(DataTable source)
        {
            dgClientOrders.DataSource = source;

            // Set Columns as ReadOnly
            for (int i = 0; i < dgClientOrders.ColumnCount; i++)
                dgClientOrders.Columns[i].ReadOnly = true;

            // Add Edit Column
            if (dgClientOrders.Columns["EditColumn"] == null)
                dgClientOrders.Columns.Add(new DataGridViewButtonColumn() { Name="EditColumn", Text="Edit", HeaderText="", UseColumnTextForButtonValue = true });

            // Add View Schedule Column
            if (dgClientOrders.Columns["ViewScheduleColumn"] == null)
                dgClientOrders.Columns.Add(new DataGridViewButtonColumn() { Name = "ViewScheduleColumn", Text = "View Schedule", HeaderText = "", UseColumnTextForButtonValue = true });
        }

        private void OrderSearchUILoadEvent(object sender, EventArgs e)
        {
            presenter.SetClientList();
        }

        private void CustomerName_SelectedIndexChange(object sender, EventArgs e)
        {
            presenter.UpdateOrderList(((KeyValuePair<int, string>)cmbCustomerNames.SelectedItem).Key);
        }

        private void DataGrid_ClientOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgClientOrders.Rows[e.RowIndex];
            int orderID = (int)row.Cells[dgClientOrders.Columns["Order ID"].Index].Value;


            if (e.ColumnIndex == dgClientOrders.Columns["EditColumn"].Index)
                ShowEditOrder(orderID);
            else if (e.ColumnIndex == dgClientOrders.Columns["ViewScheduleColumn"].Index)
                ShowViewSchedule(orderID);
        }

        private void ShowEditOrder(int orderID)
        {
            presenter.ShowEditOrder(orderID);
        }

        private void ShowViewSchedule(int orderID)
        {

        }
    }
}
