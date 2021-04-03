using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cw2.common;

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
            populateGrid();
        }

        private void populateGrid()
        {
            dataGridTransaction.AutoGenerateColumns = false;
            TransactionService service = new TransactionService();
            List<TransactionDto> transactionList = service.getAllTransactions();
            dataGridTransaction.DataSource = transactionList;
            reset();
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
            List<KeyValuePair<int, String>> monthOfYear = new List<KeyValuePair<int, string>>();
            monthOfYear.Add(new KeyValuePair<int, string>(1, "Jan"));
            monthOfYear.Add(new KeyValuePair<int, string>(2, "Feb"));
            monthOfYear.Add(new KeyValuePair<int, string>(3, "Mar"));
            monthOfYear.Add(new KeyValuePair<int, string>(4, "Apr"));
            monthOfYear.Add(new KeyValuePair<int, string>(5, "May"));
            monthOfYear.Add(new KeyValuePair<int, string>(6, "Jun"));
            monthOfYear.Add(new KeyValuePair<int, string>(7, "Jul"));
            monthOfYear.Add(new KeyValuePair<int, string>(8, "Aug"));
            monthOfYear.Add(new KeyValuePair<int, string>(9, "Sep"));
            monthOfYear.Add(new KeyValuePair<int, string>(10, "Oct"));
            monthOfYear.Add(new KeyValuePair<int, string>(11, "Nov"));
            monthOfYear.Add(new KeyValuePair<int, string>(12, "Dec"));

            cmbMonth.DataSource = monthOfYear;
            cmbMonth.DisplayMember = "Value";
            cmbMonth.ValueMember = "Key";

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
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                TransactionService transactionService = new TransactionService();

                model.Title = txtTxnTitle.Text;
                model.Amount = Convert.ToDouble(txtTxnAmount.Text);
                model.Date = dtpDate.Value;

                //set the type field.

                if (rBtnIncome.Checked)
                {
                    model.Type = AppConstant.INCOME;
                }
                else
                {
                    model.Type = AppConstant.EXPENSE;
                }

                //set occurence field

                if (rBtnOneOff.Checked)
                {
                    model.Occurence = AppConstant.ONE_OFF;
                }
                else
                {
                    model.Occurence = AppConstant.RECURRENCE;
                }

                model.ExpireDate = dtpExpireDate.Value;
                model.RecurrenceType = cmbRecurrenceType.Text;
                model.OnDate = Convert.ToInt32(txtDay.Text);
                model.OnMonth = Convert.ToInt32(((KeyValuePair<int, string>)cmbMonth.SelectedItem).Key);
                
                transactionService.save(model);

                populateGrid();
            } 
        }

        private void reset()
        {
            txtTxnTitle.Text = dtpDate.Text = txtTxnAmount.Text = cmbRecurrenceType.Text = dtpExpireDate.Text = txtDay.Text = cmbMonth.Text = null;
            btnSave.Text = "Save";
            model.Id = 0;
        }

        private void validateTitle(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTxnTitle.Text))
            {
                e.Cancel = true;
                txtTxnTitle.Focus();
                errorProvider.SetError(txtTxnTitle, "Title is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtTxnTitle, "");
            }
        }

        private void txtTxnTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void onAmountKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) || e.KeyChar.Equals(".");
        }
    }
}
