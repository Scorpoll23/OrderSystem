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
    public partial class ViewOrderItemsUI : Form, IViewOrderItemsUI
    {
        private ViewOrderItemsPresenter presenter;

        public ViewOrderItemsUI()
        {
            InitializeComponent();

            dgOrderItems.AllowUserToAddRows = false;
            dgOrderItems.AllowUserToDeleteRows = false;
        }

        public void Register(ViewOrderItemsPresenter presenter)
        {
            this.presenter = presenter;
        }

        public void SetOrderItemsList(DataTable orderItemsList)
        {
            dgOrderItems.DataSource = orderItemsList;
            dgOrderItems.AutoResizeColumns();

            // Set Columns as ReadOnly
            for (int i = 0; i < dgOrderItems.ColumnCount; i++)
                dgOrderItems.Columns[i].ReadOnly = true;
        }
    }
}
