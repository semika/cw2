using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw2.transaction
{
    public partial class FormNewTransaction : Form
    {
        TransactionDto model = new TransactionDto(); //model

        public FormNewTransaction()
        {
            InitializeComponent();
        }

        private void onNewTransactionFormLoad(object sender, EventArgs e)
        {
            pupulateDefault();
            poulateOccurenceDropDown();
            populateMonth();
        }

        private void pupulateDefault()
        {
            rBtnIncome.Checked = true;
            rBtnOneOff.Checked = true;

            lblRecurrenceType.Visible = false;
            cmbRecurrenceType.Visible = false;

           

            lblDay.Visible = false;
            txtDay.Visible = false;

            lblMonth.Visible = false;
            cmbMonth.Visible = false;

            lblExpireDate.Visible = false;
            dtpExpireDate.Visible = false;
        }

        private void poulateOccurenceDropDown()
        {
            cmbRecurrenceType.Items.Add("none");
            cmbRecurrenceType.Items.Add("Daily");
            cmbRecurrenceType.Items.Add("Weekly");
            cmbRecurrenceType.Items.Add("Monthly");
            cmbRecurrenceType.Items.Add("Yearly");
        }

        private void populateMonth()
        {
            cmbMonth.Items.Add("Jan");
            cmbMonth.Items.Add("Feb");
            cmbMonth.Items.Add("Mar");
            cmbMonth.Items.Add("Apr");
            cmbMonth.Items.Add("May");
            cmbMonth.Items.Add("Jun");
            cmbMonth.Items.Add("Jul");
            cmbMonth.Items.Add("Aug");
            cmbMonth.Items.Add("Sep");
            cmbMonth.Items.Add("Oct");
            cmbMonth.Items.Add("Nov");
            cmbMonth.Items.Add("Dec");
        }

        private void rBtnIncome_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupAddEditTransaction_Enter(object sender, EventArgs e)
        {

        }

        private void onBtnOneOffChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                lblRecurrenceType.Visible = false;
                cmbRecurrenceType.Visible = false;
                cmbRecurrenceType.Text = null;
            }
            else
            {

            }
        }

        private void onrBtnRecurrenceChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                lblRecurrenceType.Visible = true;
                cmbRecurrenceType.Visible = true;
            }
            else
            {

            }
        }

        private void onRecurrenceTypeChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            string recurrentType = comboBox.Text;

            switch (recurrentType)
            {
                case "none":
                    dtpExpireDate.Visible = false;
                    lblExpireDate.Visible = false;
                    lblDay.Visible = false;
                    txtDay.Visible = false;
                    lblMonth.Visible = false;
                    cmbMonth.Visible = false;
                    break;
                case "Daily":
                    lblDay.Visible = false;
                    txtDay.Visible = false;
                    lblExpireDate.Visible = true;
                    dtpExpireDate.Visible = true;
                    lblMonth.Visible = false;
                    cmbMonth.Visible = false;
                    break;
                case "Weekly":
                    lblDay.Text = "Day of Week";
                    lblDay.Visible = true;
                    txtDay.Visible = true;
                    lblExpireDate.Visible = true;
                    dtpExpireDate.Visible = true;
                    lblMonth.Visible = false;
                    cmbMonth.Visible = false;
                    break;
                case "Monthly":
                    lblDay.Text = "Day of Month";
                    lblDay.Visible = true;
                    txtDay.Visible = true;
                    lblExpireDate.Visible = true;
                    dtpExpireDate.Visible = true;
                    lblMonth.Visible = false;
                    cmbMonth.Visible = false;
                    break;
                case "Yearly":
                    lblDay.Text = "Day of Month";
                    lblDay.Visible = true;
                    txtDay.Visible = true;
                    lblExpireDate.Visible = true;
                    dtpExpireDate.Visible = true;
                    lblMonth.Visible = true;
                    cmbMonth.Visible = true;
                    break;
            }
        }

        private void onBtnSaveTransactionClick(object sender, EventArgs e)
        {
            TransactionService transactionService = new TransactionService();

            model.Title = txtTxnTitle.Text;
            model.Amount = Convert.ToDouble(txtTxnAmount.Text);
            model.Date = dtpDate.Value;
            model.ExpireDate = dtpExpireDate.Value;
            model.Occurence = cmbRecurrenceType.Text;
            model.RecurrenceType = cmbRecurrenceType.Text;

        }

        private void reset()
        {
            txtName.Text = txtAddress.Text = txtTel.Text = txtEmail.Text = cmbType.Text = null;
            btnSave.Text = "Save";
            model.Id = 0;
        }
    }
}
