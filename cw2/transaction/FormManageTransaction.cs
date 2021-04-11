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
        public FormManageTransaction()
        {
            InitializeComponent();
            fetchDataByCriteria();
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
                Title = txtTitle.Text
            };

            dataGridTransaction.AutoGenerateColumns = false;
            TransactionService service = new TransactionService();
            List<TransactionDto> transactionList = service.searchTransactionByCriteria(dto);

            dataGridTransaction.DataSource = transactionList;
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

        }
    }
}
