namespace IronHelmOrderSystem.Views
{
    partial class ViewScheduleUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgScheduleList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgScheduleList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "* Showing all schedule items 2 months before and after this Order. This Order\'s S" +
    "chedule is highlighted in Yellow.";
            // 
            // dgScheduleList
            // 
            this.dgScheduleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgScheduleList.Location = new System.Drawing.Point(2, 0);
            this.dgScheduleList.Name = "dgScheduleList";
            this.dgScheduleList.Size = new System.Drawing.Size(647, 198);
            this.dgScheduleList.TabIndex = 2;
            this.dgScheduleList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgScheduleList_CellFormatting);
            // 
            // ViewScheduleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 223);
            this.Controls.Add(this.dgScheduleList);
            this.Controls.Add(this.label1);
            this.Name = "ViewScheduleUI";
            this.Text = "ViewSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.dgScheduleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgScheduleList;
    }
}