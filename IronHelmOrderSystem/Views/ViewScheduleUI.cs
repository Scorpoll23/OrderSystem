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
    public partial class ViewScheduleUI : Form, IViewScheduleUI
    {
        private ViewSchedulePresenter presenter;

        public ViewScheduleUI()
        {
            InitializeComponent();

            dgScheduleList.AllowUserToAddRows = false;
            dgScheduleList.AllowUserToDeleteRows = false;
        }

        public void Register(ViewSchedulePresenter presenter)
        {
            this.presenter = presenter;
        }

        public void SetScheduleList(DataTable scheduleList)
        {
            dgScheduleList.DataSource = scheduleList;
            dgScheduleList.AutoResizeColumns();

            // Set Columns as ReadOnly
            for (int i = 0; i < dgScheduleList.ColumnCount; i++)
                dgScheduleList.Columns[i].ReadOnly = true;
        }

        private void dgScheduleList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int orderID = presenter.GetOrderID();

            if (orderID != 0 && dgScheduleList.Rows.Count > 0)
                foreach (DataGridViewRow row in dgScheduleList.Rows)
                    if ((int)row.Cells[0].Value == orderID)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    }
        }
    }
}
