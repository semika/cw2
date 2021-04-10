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

            List<TransactionDto> dataSetList = service.getAllTransactionsFromDataSet();

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
            cmbMonth.Items.Add("January");
            cmbMonth.Items.Add("February");
            cmbMonth.Items.Add("March"); 
            cmbMonth.Items.Add("April"); 
            cmbMonth.Items.Add("May"); 
            cmbMonth.Items.Add("June"); 
            cmbMonth.Items.Add("July"); 
            cmbMonth.Items.Add("Augest");
            cmbMonth.Items.Add("September");
            cmbMonth.Items.Add("October");
            cmbMonth.Items.Add("November");
            cmbMonth.Items.Add("December");
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
                model.OnMonth = cmbMonth.SelectedItem.ToString();
                model.ExpireDate = dtpExpireDate.Value;
                
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

        private void onAmountKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) || e.KeyChar.Equals(".");
        }

        private void onGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) //Header row index will be zero
            {
                //Highlte the row
                dataGridTransaction.Rows[dataGridTransaction.CurrentRow.Index].Selected = true;

                DataGridViewRow selectedRow = dataGridTransaction.Rows[e.RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                String title = Convert.ToString(selectedRow.Cells["Title"].Value);
                double amount = Convert.ToDouble(selectedRow.Cells["Amount"].Value);
                DateTime date = Convert.ToDateTime(selectedRow.Cells["Date"].Value);
                DateTime expireDate = Convert.ToDateTime(selectedRow.Cells["ExpireDate"].Value);
                String type = Convert.ToString(selectedRow.Cells["Type"].Value);
                String occurence = Convert.ToString(selectedRow.Cells["Occurence"].Value);
                String recurrenceType = Convert.ToString(selectedRow.Cells["RecurrenceType"].Value);
                int onDate = Convert.ToInt32(selectedRow.Cells["OnDate"].Value);
                String onMonth = Convert.ToString(selectedRow.Cells["OnMonth"].Value);

                txtTxnTitle.Text = title;
                txtTxnAmount.Text = amount.ToString();
                dtpDate.Value = date;

                //set income or expnse
                if (type.Equals("INCOME"))
                {
                    rBtnIncome.Checked = true;
                }
                else
                {
                    rBtnExpense.Checked = true;
                }

                //Set occurence
                if (occurence.Equals("RECURRENCE"))
                {
                    rBtnRecurrence.Checked = true;
                }
                else
                {
                    rBtnOneOff.Checked = true;
                }

                cmbRecurrenceType.SelectedItem = recurrenceType;
                dtpExpireDate.Value = expireDate;
                txtDay.Text = onDate.ToString();
                cmbMonth.SelectedItem = onMonth;   

                model.Id = id;
                btnSave.Text = "Update";


            }
        }

        private void onBtnResetClick(object sender, MouseEventArgs e)
        {
            reset();
        }
    }
}
