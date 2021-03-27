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

namespace cw2
{
    public partial class FormNewContact : Form
    {
        ContactDto model = new ContactDto(); //model

        public FormNewContact()
        {
            InitializeComponent();
        }

        private void onContactFormLoad(object sender, EventArgs e)
        {
            populateGrid();
            populateTypeComboBox();
            reset();
        }

        private void populateTypeComboBox()
        {
            cmbType.Items.Add("Payer");
            cmbType.Items.Add("Payee");
        }

        private void contactGroup_Enter(object sender, EventArgs e)
        {

        }

        private void onSaveButtonClick(object sender, EventArgs e)
        {

            model.Name = txtName.Text.Trim();
            model.Address = txtAddress.Text.Trim();
            model.Email = txtEmail.Text.Trim();
            model.Tel = txtTel.Text.Trim();
            model.Type = cmbType.Text.Trim();

            ContactService service = new ContactService();
            model = service.save(model);
            showSuccessStatus("Contact was saved successfully:" + model.Id);
            populateGrid();

            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9KUI6OD;Initial Catalog=IIT-EAD;Integrated Security=True");
            try
            {

                
                /*SqlCommand command = new SqlCommand("insert into contact values(1, 'Semika Siriwardana', 'Athurugiriya', 'semika.siriwardana@gmail.com', '0713258253')", con);
                con.Open();
                command.ExecuteNonQuery();*/
                

               /* SqlDataAdapter adapter = new SqlDataAdapter("select * from contact", con);
                DataTable dT = new DataTable();
                adapter.Fill(dT);

                foreach(DataRow row in dT.Rows)
                {
                    Console.WriteLine(row["NAME"]);
                }*/

                //int rowsAffected = adapter.InsertCommand.ExecuteNonQuery();

               // SqlTransaction sqlTransaction =  con.BeginTransaction();
                //int rowsAffected = command.ExecuteNonQuery();

                //con.Close();

                
               // sqlTransaction.Commit();
            } 
            catch (Exception exe)
            {
                Console.WriteLine(exe.StackTrace);
                MessageBox.Show("Contact save failed..!" + exe.StackTrace);
            } 
            finally
            {
              /*  if (con != null)
                {
                    con.Close();
                }*/
            }

           
        }

        private void populateGrid()
        {
            dataGridContact.AutoGenerateColumns = false;
            ContactService service = new ContactService();
            List<ContactDto> contactList = service.getAllContacts();
            dataGridContact.DataSource = contactList;
            reset();
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

        private void onGridClick(object sender, MouseEventArgs e)
        {
            
            
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

        private void contactStatusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
                    ContactService service = new ContactService();
                    service.delete(model.Id);
                    populateGrid();
                    showSuccessStatus("Record Deleted Successfully");
                }
            }
        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }

        private void onBtnSubmitClick(object sender, EventArgs e)
        {
            // Read all JSON data and save those into the database.
        }
    }
}
