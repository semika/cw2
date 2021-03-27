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
        public FormNewTransaction()
        {
            InitializeComponent();
        }

        private void onNewTransactionFormLoad(object sender, EventArgs e)
        {
            pupulateDefault();
            poulateOccurenceDropDown();
            populateDayOfWeek();
            populateMonth();
        }

        private void pupulateDefault()
        {
            rBtnIncome.Checked = true;
            rBtnOneOff.Checked = true;

            lblOccurence.Visible = false;
            cmbOccurence.Visible = false;

            lblDayOfWeek.Visible = false;
            cmbDayOfWeek.Visible = false;

            lblDayOfMonth.Visible = false;
            lblDayOfMonthDay.Visible = false;
            txtDayOfMonth.Visible = false;

            lblDayOfYear.Visible = false;
            lblDayOfYearDay.Visible = false;
            txtDayOfYear.Visible = false;
            lblDayOfYearMonth.Visible = false;
            cmdMonthOfYear.Visible = false;

            lblExpireDate.Visible = false;
            dtpExpireDate.Visible = false;
        }

        private void poulateOccurenceDropDown()
        {
            cmbOccurence.Items.Add("Daily");
            cmbOccurence.Items.Add("Weekly");
            cmbOccurence.Items.Add("Monthly");
            cmbOccurence.Items.Add("Yearly");
        }

        private void populateDayOfWeek()
        {
            cmbDayOfWeek.Items.Add("Sunday");
            cmbDayOfWeek.Items.Add("Monday");
            cmbDayOfWeek.Items.Add("Tuesday");
            cmbDayOfWeek.Items.Add("Wednessday");
            cmbDayOfWeek.Items.Add("Thursday");
            cmbDayOfWeek.Items.Add("Friday");
            cmbDayOfWeek.Items.Add("Saturday");
        }

        private void populateMonth()
        {
            cmdMonthOfYear.Items.Add("Jan");
            cmdMonthOfYear.Items.Add("Feb");
            cmdMonthOfYear.Items.Add("Mar");
            cmdMonthOfYear.Items.Add("Apr");
            cmdMonthOfYear.Items.Add("May");
            cmdMonthOfYear.Items.Add("Jun");
            cmdMonthOfYear.Items.Add("Jul");
            cmdMonthOfYear.Items.Add("Aug");
            cmdMonthOfYear.Items.Add("Sep");
            cmdMonthOfYear.Items.Add("Oct");
            cmdMonthOfYear.Items.Add("Nov");
            cmdMonthOfYear.Items.Add("Dec");
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
                lblOccurence.Visible = false;
                cmbOccurence.Visible = false;
                cmbOccurence.Text = null;
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
                lblOccurence.Visible = true;
                cmbOccurence.Visible = true;
            }
            else
            {

            }
        }
    }
}
