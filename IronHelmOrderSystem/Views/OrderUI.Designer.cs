
namespace IronHelmOrderSystem.Views
{
    partial class OrderUI
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
            this.btn_radioNewCustomer = new System.Windows.Forms.RadioButton();
            this.btn_radioExistingCustomer = new System.Windows.Forms.RadioButton();
            this.txt_customerName = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_homeNameNumber = new System.Windows.Forms.TextBox();
            this.txt_address1 = new System.Windows.Forms.TextBox();
            this.txt_address2 = new System.Windows.Forms.TextBox();
            this.txt_postcode = new System.Windows.Forms.TextBox();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.lbl_address1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_existingCustomerName = new System.Windows.Forms.ComboBox();
            this.txt_existingHomeNameNumber = new System.Windows.Forms.TextBox();
            this.txt_existingAddress1 = new System.Windows.Forms.TextBox();
            this.txt_existingAddress2 = new System.Windows.Forms.TextBox();
            this.txt_existingPostcode = new System.Windows.Forms.TextBox();
            this.txt_existingCountry = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_uploadImage = new System.Windows.Forms.Button();
            this.pbx_uploadedImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbOrderSource = new System.Windows.Forms.ComboBox();
            this.lblOrderSource = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.gbOrderDetails = new System.Windows.Forms.GroupBox();
            this.txtOrderName = new System.Windows.Forms.TextBox();
            this.lblOrderName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_uploadedImage)).BeginInit();
            this.gbOrderDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_radioNewCustomer
            // 
            this.btn_radioNewCustomer.AutoSize = true;
            this.btn_radioNewCustomer.Location = new System.Drawing.Point(133, 19);
            this.btn_radioNewCustomer.Name = "btn_radioNewCustomer";
            this.btn_radioNewCustomer.Size = new System.Drawing.Size(94, 17);
            this.btn_radioNewCustomer.TabIndex = 0;
            this.btn_radioNewCustomer.TabStop = true;
            this.btn_radioNewCustomer.Text = "New Customer";
            this.btn_radioNewCustomer.UseVisualStyleBackColor = true;
            this.btn_radioNewCustomer.CheckedChanged += new System.EventHandler(this.btn_radioNewCustomer_CheckedChanged);
            // 
            // btn_radioExistingCustomer
            // 
            this.btn_radioExistingCustomer.AutoSize = true;
            this.btn_radioExistingCustomer.Location = new System.Drawing.Point(296, 19);
            this.btn_radioExistingCustomer.Name = "btn_radioExistingCustomer";
            this.btn_radioExistingCustomer.Size = new System.Drawing.Size(105, 17);
            this.btn_radioExistingCustomer.TabIndex = 1;
            this.btn_radioExistingCustomer.TabStop = true;
            this.btn_radioExistingCustomer.Text = "ExistingCustomer";
            this.btn_radioExistingCustomer.UseVisualStyleBackColor = true;
            this.btn_radioExistingCustomer.CheckedChanged += new System.EventHandler(this.btn_radioExistingCustomer_CheckedChanged);
            // 
            // txt_customerName
            // 
            this.txt_customerName.Location = new System.Drawing.Point(133, 42);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(140, 20);
            this.txt_customerName.TabIndex = 2;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 49);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(80, 13);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Customer name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Home Name/Number";
            // 
            // txt_homeNameNumber
            // 
            this.txt_homeNameNumber.Location = new System.Drawing.Point(133, 68);
            this.txt_homeNameNumber.Name = "txt_homeNameNumber";
            this.txt_homeNameNumber.Size = new System.Drawing.Size(140, 20);
            this.txt_homeNameNumber.TabIndex = 6;
            // 
            // txt_address1
            // 
            this.txt_address1.Location = new System.Drawing.Point(133, 94);
            this.txt_address1.Name = "txt_address1";
            this.txt_address1.Size = new System.Drawing.Size(140, 20);
            this.txt_address1.TabIndex = 7;
            // 
            // txt_address2
            // 
            this.txt_address2.Location = new System.Drawing.Point(133, 120);
            this.txt_address2.Name = "txt_address2";
            this.txt_address2.Size = new System.Drawing.Size(140, 20);
            this.txt_address2.TabIndex = 8;
            // 
            // txt_postcode
            // 
            this.txt_postcode.Location = new System.Drawing.Point(133, 146);
            this.txt_postcode.Name = "txt_postcode";
            this.txt_postcode.Size = new System.Drawing.Size(140, 20);
            this.txt_postcode.TabIndex = 9;
            // 
            // txt_country
            // 
            this.txt_country.Location = new System.Drawing.Point(133, 172);
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(140, 20);
            this.txt_country.TabIndex = 10;
            // 
            // lbl_address1
            // 
            this.lbl_address1.AutoSize = true;
            this.lbl_address1.Location = new System.Drawing.Point(12, 101);
            this.lbl_address1.Name = "lbl_address1";
            this.lbl_address1.Size = new System.Drawing.Size(54, 13);
            this.lbl_address1.TabIndex = 11;
            this.lbl_address1.Text = "Address 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Address 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Postcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Country";
            // 
            // cmb_existingCustomerName
            // 
            this.cmb_existingCustomerName.FormattingEnabled = true;
            this.cmb_existingCustomerName.Location = new System.Drawing.Point(296, 42);
            this.cmb_existingCustomerName.Name = "cmb_existingCustomerName";
            this.cmb_existingCustomerName.Size = new System.Drawing.Size(140, 21);
            this.cmb_existingCustomerName.TabIndex = 15;
            // 
            // txt_existingHomeNameNumber
            // 
            this.txt_existingHomeNameNumber.Location = new System.Drawing.Point(296, 69);
            this.txt_existingHomeNameNumber.Name = "txt_existingHomeNameNumber";
            this.txt_existingHomeNameNumber.Size = new System.Drawing.Size(140, 20);
            this.txt_existingHomeNameNumber.TabIndex = 16;
            // 
            // txt_existingAddress1
            // 
            this.txt_existingAddress1.Location = new System.Drawing.Point(296, 95);
            this.txt_existingAddress1.Name = "txt_existingAddress1";
            this.txt_existingAddress1.Size = new System.Drawing.Size(140, 20);
            this.txt_existingAddress1.TabIndex = 17;
            // 
            // txt_existingAddress2
            // 
            this.txt_existingAddress2.Location = new System.Drawing.Point(296, 121);
            this.txt_existingAddress2.Name = "txt_existingAddress2";
            this.txt_existingAddress2.Size = new System.Drawing.Size(140, 20);
            this.txt_existingAddress2.TabIndex = 18;
            // 
            // txt_existingPostcode
            // 
            this.txt_existingPostcode.Location = new System.Drawing.Point(296, 147);
            this.txt_existingPostcode.Name = "txt_existingPostcode";
            this.txt_existingPostcode.Size = new System.Drawing.Size(140, 20);
            this.txt_existingPostcode.TabIndex = 19;
            // 
            // txt_existingCountry
            // 
            this.txt_existingCountry.Location = new System.Drawing.Point(296, 173);
            this.txt_existingCountry.Name = "txt_existingCountry";
            this.txt_existingCountry.Size = new System.Drawing.Size(140, 20);
            this.txt_existingCountry.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_address1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_country);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.txt_existingCountry);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_existingPostcode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_existingAddress2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_existingAddress1);
            this.groupBox1.Controls.Add(this.txt_homeNameNumber);
            this.groupBox1.Controls.Add(this.txt_existingHomeNameNumber);
            this.groupBox1.Controls.Add(this.txt_address1);
            this.groupBox1.Controls.Add(this.cmb_existingCustomerName);
            this.groupBox1.Controls.Add(this.txt_address2);
            this.groupBox1.Controls.Add(this.txt_postcode);
            this.groupBox1.Controls.Add(this.btn_radioNewCustomer);
            this.groupBox1.Controls.Add(this.btn_radioExistingCustomer);
            this.groupBox1.Controls.Add(this.txt_customerName);
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 211);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_uploadImage);
            this.groupBox2.Controls.Add(this.pbx_uploadedImage);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 397);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Details";
            // 
            // btn_uploadImage
            // 
            this.btn_uploadImage.Location = new System.Drawing.Point(133, 359);
            this.btn_uploadImage.Name = "btn_uploadImage";
            this.btn_uploadImage.Size = new System.Drawing.Size(303, 23);
            this.btn_uploadImage.TabIndex = 28;
            this.btn_uploadImage.Text = "Upload Image";
            this.btn_uploadImage.UseVisualStyleBackColor = true;
            this.btn_uploadImage.Click += new System.EventHandler(this.btn_uploadImage_Click);
            // 
            // pbx_uploadedImage
            // 
            this.pbx_uploadedImage.Location = new System.Drawing.Point(133, 129);
            this.pbx_uploadedImage.Name = "pbx_uploadedImage";
            this.pbx_uploadedImage.Size = new System.Drawing.Size(303, 224);
            this.pbx_uploadedImage.TabIndex = 27;
            this.pbx_uploadedImage.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Artwork";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(133, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(303, 77);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Product Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Product name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 20);
            this.textBox1.TabIndex = 3;
            // 
            // cbOrderSource
            // 
            this.cbOrderSource.FormattingEnabled = true;
            this.cbOrderSource.Location = new System.Drawing.Point(61, 45);
            this.cbOrderSource.Name = "cbOrderSource";
            this.cbOrderSource.Size = new System.Drawing.Size(146, 21);
            this.cbOrderSource.TabIndex = 30;
            // 
            // lblOrderSource
            // 
            this.lblOrderSource.AutoSize = true;
            this.lblOrderSource.Location = new System.Drawing.Point(14, 48);
            this.lblOrderSource.Name = "lblOrderSource";
            this.lblOrderSource.Size = new System.Drawing.Size(41, 13);
            this.lblOrderSource.TabIndex = 29;
            this.lblOrderSource.Text = "Source";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 777);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Submit Enquiry";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(12, 777);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 24;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // gbOrderDetails
            // 
            this.gbOrderDetails.Controls.Add(this.txtOrderName);
            this.gbOrderDetails.Controls.Add(this.lblOrderName);
            this.gbOrderDetails.Controls.Add(this.cbOrderSource);
            this.gbOrderDetails.Controls.Add(this.lblOrderSource);
            this.gbOrderDetails.Location = new System.Drawing.Point(12, 13);
            this.gbOrderDetails.Name = "gbOrderDetails";
            this.gbOrderDetails.Size = new System.Drawing.Size(496, 94);
            this.gbOrderDetails.TabIndex = 25;
            this.gbOrderDetails.TabStop = false;
            this.gbOrderDetails.Text = "Order Details";
            // 
            // txtOrderName
            // 
            this.txtOrderName.Location = new System.Drawing.Point(61, 17);
            this.txtOrderName.Name = "txtOrderName";
            this.txtOrderName.Size = new System.Drawing.Size(146, 20);
            this.txtOrderName.TabIndex = 32;
            // 
            // lblOrderName
            // 
            this.lblOrderName.AutoSize = true;
            this.lblOrderName.Location = new System.Drawing.Point(15, 20);
            this.lblOrderName.Name = "lblOrderName";
            this.lblOrderName.Size = new System.Drawing.Size(35, 13);
            this.lblOrderName.TabIndex = 31;
            this.lblOrderName.Text = "Name";
            // 
            // OrderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 820);
            this.Controls.Add(this.gbOrderDetails);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderUI";
            this.Text = "NewEnquiry";
            this.Load += new System.EventHandler(this.NewEnquiry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_uploadedImage)).EndInit();
            this.gbOrderDetails.ResumeLayout(false);
            this.gbOrderDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton btn_radioNewCustomer;
        private System.Windows.Forms.RadioButton btn_radioExistingCustomer;
        private System.Windows.Forms.TextBox txt_customerName;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_homeNameNumber;
        private System.Windows.Forms.TextBox txt_address1;
        private System.Windows.Forms.TextBox txt_address2;
        private System.Windows.Forms.TextBox txt_postcode;
        private System.Windows.Forms.TextBox txt_country;
        private System.Windows.Forms.Label lbl_address1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_existingCustomerName;
        private System.Windows.Forms.TextBox txt_existingHomeNameNumber;
        private System.Windows.Forms.TextBox txt_existingAddress1;
        private System.Windows.Forms.TextBox txt_existingAddress2;
        private System.Windows.Forms.TextBox txt_existingPostcode;
        private System.Windows.Forms.TextBox txt_existingCountry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_uploadImage;
        private System.Windows.Forms.PictureBox pbx_uploadedImage;
        private System.Windows.Forms.ComboBox cbOrderSource;
        private System.Windows.Forms.Label lblOrderSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox gbOrderDetails;
        private System.Windows.Forms.TextBox txtOrderName;
        private System.Windows.Forms.Label lblOrderName;
    }
}