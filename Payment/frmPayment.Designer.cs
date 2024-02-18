namespace Payment
{
    partial class frmPayment
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
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.rdoBillCustomer = new System.Windows.Forms.RadioButton();
            this.rdoCreditCard = new System.Windows.Forms.RadioButton();
            this.lstCreditCardType = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboExpirationMonth = new System.Windows.Forms.ComboBox();
            this.cboExpirationYear = new System.Windows.Forms.ComboBox();
            this.chkDefault = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.rdoBillCustomer);
            this.groupbox1.Controls.Add(this.rdoCreditCard);
            this.groupbox1.Location = new System.Drawing.Point(24, 12);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(349, 67);
            this.groupbox1.TabIndex = 7;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Billing";
            // 
            // rdoBillCustomer
            // 
            this.rdoBillCustomer.AutoSize = true;
            this.rdoBillCustomer.Location = new System.Drawing.Point(198, 32);
            this.rdoBillCustomer.Name = "rdoBillCustomer";
            this.rdoBillCustomer.Size = new System.Drawing.Size(84, 17);
            this.rdoBillCustomer.TabIndex = 2;
            this.rdoBillCustomer.TabStop = true;
            this.rdoBillCustomer.Text = "Bill customer";
            this.rdoBillCustomer.UseVisualStyleBackColor = true;
            // 
            // rdoCreditCard
            // 
            this.rdoCreditCard.AutoSize = true;
            this.rdoCreditCard.Checked = true;
            this.rdoCreditCard.Location = new System.Drawing.Point(29, 32);
            this.rdoCreditCard.Name = "rdoCreditCard";
            this.rdoCreditCard.Size = new System.Drawing.Size(76, 17);
            this.rdoCreditCard.TabIndex = 1;
            this.rdoCreditCard.TabStop = true;
            this.rdoCreditCard.Text = "Credit card";
            this.rdoCreditCard.UseVisualStyleBackColor = true;
            // 
            // lstCreditCardType
            // 
            this.lstCreditCardType.FormattingEnabled = true;
            this.lstCreditCardType.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "American Express"});
            this.lstCreditCardType.Location = new System.Drawing.Point(130, 96);
            this.lstCreditCardType.Name = "lstCreditCardType";
            this.lstCreditCardType.Size = new System.Drawing.Size(243, 82);
            this.lstCreditCardType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Credit card type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Card number:";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(130, 191);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(243, 20);
            this.txtCardNumber.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Expiration date:";
            // 
            // cboExpirationMonth
            // 
            this.cboExpirationMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExpirationMonth.FormattingEnabled = true;
            this.cboExpirationMonth.Location = new System.Drawing.Point(130, 232);
            this.cboExpirationMonth.Name = "cboExpirationMonth";
            this.cboExpirationMonth.Size = new System.Drawing.Size(121, 21);
            this.cboExpirationMonth.TabIndex = 2;
            // 
            // cboExpirationYear
            // 
            this.cboExpirationYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExpirationYear.FormattingEnabled = true;
            this.cboExpirationYear.Location = new System.Drawing.Point(257, 232);
            this.cboExpirationYear.Name = "cboExpirationYear";
            this.cboExpirationYear.Size = new System.Drawing.Size(121, 21);
            this.cboExpirationYear.TabIndex = 3;
            // 
            // chkDefault
            // 
            this.chkDefault.AutoSize = true;
            this.chkDefault.Checked = true;
            this.chkDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDefault.Location = new System.Drawing.Point(24, 274);
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Size = new System.Drawing.Size(158, 17);
            this.chkDefault.TabIndex = 4;
            this.chkDefault.Text = "Set as default billing method";
            this.chkDefault.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(165, 306);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 24);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(292, 306);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 24);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmPayment
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(407, 351);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkDefault);
            this.Controls.Add(this.cboExpirationYear);
            this.Controls.Add(this.cboExpirationMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCreditCardType);
            this.Controls.Add(this.groupbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.FrmPayment_Load_1);
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.RadioButton rdoCreditCard;
        private System.Windows.Forms.RadioButton rdoBillCustomer;
        private System.Windows.Forms.ListBox lstCreditCardType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboExpirationMonth;
        private System.Windows.Forms.ComboBox cboExpirationYear;
        private System.Windows.Forms.CheckBox chkDefault;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}