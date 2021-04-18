using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;
using cw2;
using cw2.contact;
using cw2.common;

namespace cw2
{
    public partial class FormNewContact : Form
    {
        ContactDto model;

        public FormNewContact()
        {
            this.model = new ContactDto();
            InitializeComponent();
        }

        public FormNewContact(ContactDto model)
        {
            this.model = model;
            InitializeComponent();
        }

        private void onContactFormLoad(object sender, EventArgs e)
        {
            populateGrid();
            populateTypeComboBox();
            //reset();

            if (this.model.Id != 0)
            {
                populateFormFromDto(this.model);
            }
        }

        private void populateTypeComboBox()
        {
            cmbType.Items.Add("Payer");
            cmbType.Items.Add("Payee");
        }

        private void onSaveButtonClick(object sender, EventArgs e)
        {
            model.ContactName = txtName.Text.Trim();
            model.Address = txtAddress.Text.Trim();
            model.Email = txtEmail.Text.Trim();
            model.Tel = txtTel.Text.Trim();
            model.Type = cmbType.Text.Trim();

            CW2Response< ContactDto> reponse = ContactService.Instance.save(model);
            showSuccessStatus(reponse.Message);
            if (reponse.Status.Equals(AppConstant.SUCCESS))
            {
                populateGrid();
            } 
        }

        private void populateGrid()
        {
            dataGridContact.AutoGenerateColumns = false;
            CW2Response<ContactDto> response = ContactService.Instance.getAllContactsFromDataSet();
            dataGridContact.DataSource = response.dataList;
            //reset();
        }

        private void onBtnResetClick(object sender, EventArgs e)
        {
            reset();   
        }

        private void reset()
        {
            txtName.Text = txtAddress.Text = txtTel.Text = txtEmail.Text = cmbType.Text = null;
            btnSave.Text = "Save";
            model.Id = 0;
        }

        private void onGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) //Header row index will be zero
            {
                //Highlte the row
                dataGridContact.Rows[dataGridContact.CurrentRow.Index].Selected = true;

                DataGridViewRow selectedRow = dataGridContact.Rows[e.RowIndex];
                
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                String name = Convert.ToString(selectedRow.Cells["contactName"].Value);
                String address = Convert.ToString(selectedRow.Cells["Address"].Value);
                String type = Convert.ToString(selectedRow.Cells["Type"].Value);
                String tel = Convert.ToString(selectedRow.Cells["Tel"].Value);
                String email = Convert.ToString(selectedRow.Cells["Email"].Value);

                txtName.Text = name;
                txtAddress.Text = address;
                txtTel.Text = tel;
                cmbType.Text = type;
                txtEmail.Text = email;

                model.Id = id;
                
            }
        }

        private void populateFromDataGridRow(DataGridViewRow selectedRow)
        {
            ContactDto dto = ContactTransformer.Instance.dataGridRowToDto(selectedRow);
            populateFormFromDto(dto);
        }

        private void populateFormFromDto(ContactDto dto)
        {
            txtName.Text = dto.ContactName;
            txtAddress.Text = dto.Address;
            cmbType.Text = dto.Type;
            txtTel.Text = dto.Tel;
            txtEmail.Text = dto.Email;
           
            model.Id = dto.Id;

            btnSave.Text = "Update";
        }


        private void showSuccessStatus(string message)
        {
            contactStatusStrip.ForeColor = Color.Green;
            contactStatusStrip.Text = message;
        }

        private void showFailedStatus(string message)
        {
            contactStatusStrip.ForeColor = Color.Red;
            contactStatusStrip.Text = message;
        }

        private void onBtnDeleteClick(object sender, EventArgs e)
        {
            if (dataGridContact.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure to delete this record?", "Delete Contact", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ContactService.Instance.delete(model.Id);
                    populateGrid();
                    showSuccessStatus("Record Deleted Successfully");
                }
            }
        }
    }
}
