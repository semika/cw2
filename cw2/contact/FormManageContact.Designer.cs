
namespace cw2.contact
{
    partial class FormManageContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxContactSearchForm = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBoxContactList = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridContact = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxContactSearchForm.SuspendLayout();
            this.groupBoxContactList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContact)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxContactSearchForm
            // 
            this.groupBoxContactSearchForm.Controls.Add(this.txtName);
            this.groupBoxContactSearchForm.Controls.Add(this.lblName);
            this.groupBoxContactSearchForm.Controls.Add(this.lblType);
            this.groupBoxContactSearchForm.Controls.Add(this.cmbType);
            this.groupBoxContactSearchForm.Controls.Add(this.btnReset);
            this.groupBoxContactSearchForm.Controls.Add(this.btnSearch);
            this.groupBoxContactSearchForm.Location = new System.Drawing.Point(12, 12);
            this.groupBoxContactSearchForm.Name = "groupBoxContactSearchForm";
            this.groupBoxContactSearchForm.Size = new System.Drawing.Size(1172, 132);
            this.groupBoxContactSearchForm.TabIndex = 0;
            this.groupBoxContactSearchForm.TabStop = false;
            this.groupBoxContactSearchForm.Text = "Search Contacts";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(258, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(217, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(13, 42);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(50, 42);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(120, 87);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Clear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.onBtnResetClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(16, 87);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.onBtnSearchClick);
            // 
            // groupBoxContactList
            // 
            this.groupBoxContactList.Controls.Add(this.btnDelete);
            this.groupBoxContactList.Controls.Add(this.dataGridContact);
            this.groupBoxContactList.Controls.Add(this.btnEdit);
            this.groupBoxContactList.Location = new System.Drawing.Point(12, 150);
            this.groupBoxContactList.Name = "groupBoxContactList";
            this.groupBoxContactList.Size = new System.Drawing.Size(1172, 308);
            this.groupBoxContactList.TabIndex = 1;
            this.groupBoxContactList.TabStop = false;
            this.groupBoxContactList.Text = "Contact List";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(108, 279);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.onBtnDeleteClick);
            // 
            // dataGridContact
            // 
            this.dataGridContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ContactName,
            this.Address,
            this.Tel,
            this.Email,
            this.Type,
            this.Status});
            this.dataGridContact.Location = new System.Drawing.Point(16, 19);
            this.dataGridContact.Name = "dataGridContact";
            this.dataGridContact.Size = new System.Drawing.Size(1140, 238);
            this.dataGridContact.TabIndex = 0;
            this.dataGridContact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onDataGridContactCellClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(16, 279);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.onBtnEditClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // ContactName
            // 
            this.ContactName.DataPropertyName = "ContactName";
            this.ContactName.HeaderText = "ContactName";
            this.ContactName.Name = "ContactName";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "Tel";
            this.Tel.HeaderText = "Tel";
            this.Tel.Name = "Tel";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // FormManageContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 506);
            this.Controls.Add(this.groupBoxContactList);
            this.Controls.Add(this.groupBoxContactSearchForm);
            this.Name = "FormManageContact";
            this.Text = "FormManageContact";
            this.Load += new System.EventHandler(this.onFormManageContactLoad);
            this.groupBoxContactSearchForm.ResumeLayout(false);
            this.groupBoxContactSearchForm.PerformLayout();
            this.groupBoxContactList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxContactSearchForm;
        private System.Windows.Forms.GroupBox groupBoxContactList;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridContact;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}