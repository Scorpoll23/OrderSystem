
namespace IronHelmOrderSystem.Views
{
    partial class ClientUI
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
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.lblNumberOrName = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtNumberOrName = new System.Windows.Forms.TextBox();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSaveClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(39, 71);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine1.TabIndex = 23;
            this.lblAddressLine1.Text = "Address Line 1";
            // 
            // lblNumberOrName
            // 
            this.lblNumberOrName.AutoSize = true;
            this.lblNumberOrName.Location = new System.Drawing.Point(27, 42);
            this.lblNumberOrName.Name = "lblNumberOrName";
            this.lblNumberOrName.Size = new System.Drawing.Size(89, 13);
            this.lblNumberOrName.TabIndex = 17;
            this.lblNumberOrName.Text = "Number Or Name";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(133, 142);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(140, 20);
            this.txtCountry.TabIndex = 22;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(81, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name";
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(39, 97);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(77, 13);
            this.lblAddressLine2.TabIndex = 24;
            this.lblAddressLine2.Text = "Address Line 2";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(64, 123);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(52, 13);
            this.lblPostcode.TabIndex = 25;
            this.lblPostcode.Text = "Postcode";
            this.lblPostcode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(73, 149);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 26;
            this.lblCountry.Text = "Country";
            // 
            // txtNumberOrName
            // 
            this.txtNumberOrName.Location = new System.Drawing.Point(133, 38);
            this.txtNumberOrName.Name = "txtNumberOrName";
            this.txtNumberOrName.Size = new System.Drawing.Size(140, 20);
            this.txtNumberOrName.TabIndex = 18;
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(133, 64);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(140, 20);
            this.txtAddressLine1.TabIndex = 19;
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(133, 90);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(140, 20);
            this.txtAddressLine2.TabIndex = 20;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(133, 116);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(140, 20);
            this.txtPostcode.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 20);
            this.txtName.TabIndex = 15;
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.Location = new System.Drawing.Point(99, 182);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(75, 23);
            this.btnSaveClient.TabIndex = 27;
            this.btnSaveClient.Text = "Save";
            this.btnSaveClient.UseVisualStyleBackColor = true;
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // ClientUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 217);
            this.Controls.Add(this.btnSaveClient);
            this.Controls.Add(this.lblAddressLine1);
            this.Controls.Add(this.lblNumberOrName);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAddressLine2);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtNumberOrName);
            this.Controls.Add(this.txtAddressLine1);
            this.Controls.Add(this.txtAddressLine2);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtName);
            this.Name = "ClientUI";
            this.Text = "ClientUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.Label lblNumberOrName;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtNumberOrName;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSaveClient;
    }
}