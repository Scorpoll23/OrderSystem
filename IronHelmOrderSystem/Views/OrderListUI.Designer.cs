
namespace IronHelmOrderSystem.Views
{
    partial class OrderListUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblClientName = new System.Windows.Forms.Label();
            this.cmbCustomerNames = new System.Windows.Forms.ComboBox();
            this.lblOrderList = new System.Windows.Forms.Label();
            this.dgClientOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(12, 15);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(33, 13);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "Client";
            // 
            // cmbCustomerNames
            // 
            this.cmbCustomerNames.FormattingEnabled = true;
            this.cmbCustomerNames.Location = new System.Drawing.Point(51, 12);
            this.cmbCustomerNames.Name = "cmbCustomerNames";
            this.cmbCustomerNames.Size = new System.Drawing.Size(133, 21);
            this.cmbCustomerNames.TabIndex = 1;
            this.cmbCustomerNames.SelectedIndexChanged += new System.EventHandler(this.CustomerName_SelectedIndexChange);
            // 
            // lblOrderList
            // 
            this.lblOrderList.AutoSize = true;
            this.lblOrderList.Location = new System.Drawing.Point(12, 64);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(38, 13);
            this.lblOrderList.TabIndex = 3;
            this.lblOrderList.Text = "Orders";
            // 
            // dgClientOrders
            // 
            this.dgClientOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientOrders.Location = new System.Drawing.Point(12, 81);
            this.dgClientOrders.Name = "dgClientOrders";
            this.dgClientOrders.Size = new System.Drawing.Size(808, 240);
            this.dgClientOrders.TabIndex = 4;
            this.dgClientOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_ClientOrders_CellClick);
            // 
            // OrderListUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 351);
            this.Controls.Add(this.dgClientOrders);
            this.Controls.Add(this.lblOrderList);
            this.Controls.Add(this.cmbCustomerNames);
            this.Controls.Add(this.lblClientName);
            this.Name = "OrderListUI";
            this.Text = "OrderSearchUI";
            this.Load += new System.EventHandler(this.OrderSearchUILoadEvent);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.ComboBox cmbCustomerNames;
        private System.Windows.Forms.Label lblOrderList;
        private System.Windows.Forms.DataGridView dgClientOrders;
    }
}