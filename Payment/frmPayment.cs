using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payment
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }
        private void FrmPayment_Load_1(object sender, EventArgs e)
        {
            lstCreditCardType.Items.Clear();
            lstCreditCardType.Items.Add("Visa");
            lstCreditCardType.Items.Add("MasterCard");
            lstCreditCardType.Items.Add("American Express");
            lstCreditCardType.SelectedIndex = 0;

            string[] months = { "Select a month.....", 
                                  "January",
                                  "February", 
                                  "March",
                                  "April",
                                  "May",
                                  "June",
                                  "July",
                                  "Auguest",
                                  " September",
                                  "October",
                                 "November",
                                 " December"};

            foreach (string month in months)

            cboExpirationMonth.Items.Add(month);
            cboExpirationMonth.SelectedIndex = 0;

            int year = DateTime.Today.Year;
            int endYear = year + 8;

            cboExpirationYear.Items.Add("Selete a year ....");
            while (year < endYear)
            {
                cboExpirationYear.Items.Add(year);
                year++;
            }
            cboExpirationYear.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                this.SaveData();             
            }
        }

        private bool IsValidData()
        {
            if (rdoCreditCard.Checked)
            {
                if (lstCreditCardType.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a credit card type.", "Entry Error");
                    lstCreditCardType.Focus();
                    return false;
                }
                if (txtCardNumber.Text == "")
                {
                    MessageBox.Show("You must enter a credit card number", "Entry Error");
                    txtCardNumber.Focus();
                    return false;
                }
                if (cboExpirationMonth.SelectedIndex == 0)
                {
                    MessageBox.Show("You must selete a month.", "Entry Error");
                    cboExpirationMonth.Focus();
                    return false;
                }
                if (cboExpirationYear.SelectedIndex == 0)
                {
                    MessageBox.Show("You must selete a year.", "Entry Error");
                    cboExpirationYear.Focus();
                    return false;
                }
            }
            return true;
        }

        private void SaveData()
        {
            string msg = null;
            if (rdoCreditCard.Checked == true)
            {
                msg += "Change to credit card." + "\n";
                msg += "\n";
                msg += "Card Type: " + lstCreditCardType.Text + "/n";
                msg += "Card number:" + txtCardNumber.Text + "\n";

                msg += "Exipration date: " 
                    + cboExpirationMonth.Text +
                    "/" + cboExpirationYear.
                       Text + "\n";
            }
            else
            {
                msg += "Send bill to customer ." + "\n";
                msg += "\n";
            }
            bool isDefaultBilling = chkDefault.Checked;
            msg += "Default billing :" + isDefaultBilling;

            this.Tag = msg;
            this.DialogResult = DialogResult.OK;

        }

        private void Billing_CheckedChanged(object sender, EventArgs e)
        {         
            if (rdoCreditCard.Checked)
                EnableControls();
            else
                DisableControls();


        }

        private void EnableControls()
        {
            lstCreditCardType.Enabled = true;
            txtCardNumber.Enabled = true;
            cboExpirationMonth.Enabled = true;
            cboExpirationYear.Enabled = true;
        }
        private void DisableControls()
        {
            lstCreditCardType.Enabled = false;
            txtCardNumber.Enabled = false;
            cboExpirationMonth.Enabled = false;
            cboExpirationYear.Enabled = false;
        }
     
    }

}
