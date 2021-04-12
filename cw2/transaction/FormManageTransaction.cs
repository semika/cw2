using cw2.common;
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
    public partial class FormManageTransaction : Form
    {
        DataGridViewRow selectedRow = null;

        public FormManageTransaction()
        {
            InitializeComponent();
            fetchDataByCriteria();
            populateSearchForm();
        }

        private void populateSearchForm()
        {
            cmbType.Items.Add("");
            cmbType.Items.Add(AppConstant.INCOME);
            cmbType.Items.Add(AppConstant.EXPENSE);
        }

        private void onBtnSearchClick(object sender, EventArgs e)
        {
            fetchDataByCriteria();
        }

        private void onBtnResetClick(object sender, EventArgs e)
        {
            reset();
            fetchDataByCriteria();
        }

        private void fetchDataByCriteria()
        {
            TransactionDto dto = new TransactionDto
            {
                Title = txtTitle.Text,
                CreatedDate = dtpDate.Value,
                Type = cmbType.Text
            };

            dataGridTransaction.AutoGenerateColumns = false;
            CW2Response<TransactionDto> response  = TransactionService.Instance.searchTransactionByCriteria(dto);

            dataGridTransaction.DataSource = response.dataList;

            reset();
        }

        private void reset()
        {
            txtTitle.Text = "";
        }

        private void onBtnDeleteClick(object sender, EventArgs e)
        {

        }

        private void onBtnEditClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.selectedRow.Cells["Id"].Value);
            String title = Convert.ToString(this.selectedRow.Cells["Title"].Value);
            double amount = Convert.ToDouble(this.selectedRow.Cells["Amount"].Value);
            DateTime date = Convert.ToDateTime(this.selectedRow.Cells["Date"].Value);
            DateTime expireDate = Convert.ToDateTime(this.selectedRow.Cells["ExpireDate"].Value);
            String type = Convert.ToString(this.selectedRow.Cells["Type"].Value);
            String occurence = Convert.ToString(this.selectedRow.Cells["Occurence"].Value);
            String recurrenceType = Convert.ToString(this.selectedRow.Cells["RecurrenceType"].Value);
            int onDate = Convert.ToInt32(this.selectedRow.Cells["OnDate"].Value);
            String onMonth = Convert.ToString(this.selectedRow.Cells["OnMonth"].Value);

            TransactionDto model = new TransactionDto();
            model.Id = id;
            model.Title = title;
            model.Amount = amount;
            model.CreatedDate = date;
            model.ExpireDate = expireDate;
            model.Type = type;
            model.Occurence = occurence;
            model.RecurrenceType = recurrenceType;
            model.OnDate = onDate;
            model.OnMonth = onMonth;
            model.DbEntityId = id;

            FormNewTransaction formNewTransaction = new FormNewTransaction(model);
            formNewTransaction.Show();
        }

        private void onDataGridTransactionCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) //Header row index will be zero
            {
                //Highlte the row
                dataGridTransaction.Rows[dataGridTransaction.CurrentRow.Index].Selected = true;
                this.selectedRow = dataGridTransaction.Rows[e.RowIndex];
            }

        }

        private void groupBoxTransactionSearch_Enter(object sender, EventArgs e)
        {

        }
    }
}
