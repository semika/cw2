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

namespace cw2.contact
{
    public partial class FormManageContact : Form
    {
        DataGridViewRow selectedRow = null;

        public FormManageContact()
        {
            InitializeComponent();
        }

        private void onFormManageContactLoad(object sender, EventArgs e)
        {
            fetchDataByCriteria();
            populateSearchForm();
        }

        private void populateSearchForm()
        {
            cmbType.Items.Add("");
            cmbType.Items.Add(AppConstant.PAYEE);
            cmbType.Items.Add(AppConstant.PAYER);
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
            ContactDto dto = new ContactDto();
            if (txtName.Text.Trim().Length > 0)
            {
                dto.ContactName = txtName.Text;
            }

            if (cmbType.Text.Trim().Length > 0)
            {
                dto.Type = cmbType.Text;
            }

            dataGridContact.AutoGenerateColumns = false;
            CW2Response<ContactDto> response = ContactService.Instance.searchContactByCriteria(dto);

            dataGridContact.DataSource = response.dataList;

            reset();
        }

        private void reset()
        {
            txtName.Text = "";
        }

        private void onBtnDeleteClick(object sender, EventArgs e)
        {

        }

        private void onBtnEditClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.selectedRow.Cells["Id"].Value);
            string name = Convert.ToString(this.selectedRow.Cells["ContactName"].Value);
            string address = Convert.ToString(this.selectedRow.Cells["Address"].Value);
            string email = Convert.ToString(this.selectedRow.Cells["Email"].Value);
            string tel = Convert.ToString(this.selectedRow.Cells["Tel"].Value);
            string type = Convert.ToString(this.selectedRow.Cells["Type"].Value);

            ContactDto model = new ContactDto();
            model.Id = id;
            model.ContactName = name;
            model.Address = address;
            model.Email= email;
            model.Tel = tel;
            model.Type = type;
            model.DbEntityId = id;

            FormNewContact formNewContact = new FormNewContact(model);
            formNewContact.Show();
        }

        private void onDataGridContactCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) //Header row index will be zero
            {
                //Highlte the row
                dataGridContact.Rows[dataGridContact.CurrentRow.Index].Selected = true;
                this.selectedRow = dataGridContact.Rows[e.RowIndex];
            }

        }

    }
}
