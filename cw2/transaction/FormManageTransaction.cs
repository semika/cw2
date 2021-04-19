using cw2.common;
using System;
using System.Collections;
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
        }

        private void onManageTransactionFormLoad(object sender, EventArgs e)
        {
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
            TransactionDto dto = new TransactionDto();
            if (txtTitle.Text.Trim().Length > 0)
            {
                dto.Title = txtTitle.Text;
            }

            if (cmbType.Text.Trim().Length > 0)
            {
                dto.Type = cmbType.Text;
            }

            if (dtpDate.Value != null)
            {
                //dto.CreatedDate = dtpDate.Value;
            } else
            {
               // dto.CreatedDate = null;
            }

            dataGridTransaction.AutoGenerateColumns = false;
            
            var dataList = new ArrayList();

            //Add Draft data first
            CW2Response<TransactionDto> response1 = TransactionService.Instance.getAllTransactionsFromDataSet();
            dataList.AddRange(response1.dataList);

            //Add DB saved data
            CW2Response<TransactionDto> response  = TransactionService.Instance.searchTransactionByCriteria(dto);
            dataList.AddRange(response.dataList);

            dataGridTransaction.DataSource = dataList;

            reset();
        }

        private void reset()
        {
            txtTitle.Text = "";
        }

        private void onBtnDeleteClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.selectedRow.Cells["Id"].Value);
            string status = Convert.ToString(this.selectedRow.Cells["Status"].Value);

            if (AppConstant.DRAFT.Equals(status))
            {
                CW2Response<TransactionDto> reponse = TransactionService.Instance.removeDraft(id);
                MessageBox.Show(reponse.Message);
            }
            else
            {
                CW2Response<TransactionDto> reponse = TransactionService.Instance.delete(id);
                MessageBox.Show(reponse.Message);
            }

            fetchDataByCriteria();
        }

        private void onBtnEditClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.selectedRow.Cells["Id"].Value);
            string title = Convert.ToString(this.selectedRow.Cells["Title"].Value);
            double amount = Convert.ToDouble(this.selectedRow.Cells["Amount"].Value);
            DateTime date = Convert.ToDateTime(this.selectedRow.Cells["Date"].Value);
            DateTime expireDate = Convert.ToDateTime(this.selectedRow.Cells["ExpireDate"].Value);
            string type = Convert.ToString(this.selectedRow.Cells["Type"].Value);
            string occurence = Convert.ToString(this.selectedRow.Cells["Occurence"].Value);
            string recurrenceType = Convert.ToString(this.selectedRow.Cells["RecurrenceType"].Value);
            int onDate = Convert.ToInt32(this.selectedRow.Cells["OnDate"].Value);
            string onMonth = Convert.ToString(this.selectedRow.Cells["OnMonth"].Value);
            string status = Convert.ToString(this.selectedRow.Cells["Status"].Value);

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

            if (!AppConstant.DRAFT.Equals(status))
            {
                model.DbEntityId = id;
            }

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

       
    }
}
