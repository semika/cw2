
namespace cw2
{
    partial class FormNewContact
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
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.contactGroup = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpContactGrid = new System.Windows.Forms.GroupBox();
            this.dataGridContact = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.contactStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.contactGroup.SuspendLayout();
            this.grpContactGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContact)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(50, 33);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(35, 13);
            this.lblContactName.TabIndex = 0;
            this.lblContactName.Text = "Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(50, 85);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(53, 198);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(50, 141);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblContactNumber.TabIndex = 3;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // contactGroup
            // 
            this.contactGroup.Controls.Add(this.cmbType);
            this.contactGroup.Controls.Add(this.btnDelete);
            this.contactGroup.Controls.Add(this.lblType);
            this.contactGroup.Controls.Add(this.btnReset);
            this.contactGroup.Controls.Add(this.btnSave);
            this.contactGroup.Controls.Add(this.txtAddress);
            this.contactGroup.Controls.Add(this.txtTel);
            this.contactGroup.Controls.Add(this.txtEmail);
            this.contactGroup.Controls.Add(this.txtName);
            this.contactGroup.Controls.Add(this.lblContactName);
            this.contactGroup.Controls.Add(this.lblEmail);
            this.contactGroup.Controls.Add(this.lblContactNumber);
            this.contactGroup.Controls.Add(this.lblAddress);
            this.contactGroup.Location = new System.Drawing.Point(825, 29);
            this.contactGroup.Name = "contactGroup";
            this.contactGroup.Size = new System.Drawing.Size(446, 340);
            this.contactGroup.TabIndex = 4;
            this.contactGroup.TabStop = false;
            this.contactGroup.Text = "Contact Add/Edit";
            this.contactGroup.Enter += new System.EventHandler(this.contactGroup_Enter);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(303, 298);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.onBtnDeleteClick);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(50, 250);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "Type";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(182, 298);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.onBtnResetClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(53, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save As Draft";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.onSaveButtonClick);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(152, 85);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 20);
            this.txtAddress.TabIndex = 2;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(152, 140);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(250, 20);
            this.txtTel.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(152, 195);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(152, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 20);
            this.txtName.TabIndex = 2;
            // 
            // grpContactGrid
            // 
            this.grpContactGrid.Controls.Add(this.btnSubmit);
            this.grpContactGrid.Controls.Add(this.dataGridContact);
            this.grpContactGrid.Location = new System.Drawing.Point(35, 29);
            this.grpContactGrid.Name = "grpContactGrid";
            this.grpContactGrid.Size = new System.Drawing.Size(758, 340);
            this.grpContactGrid.TabIndex = 5;
            this.grpContactGrid.TabStop = false;
            this.grpContactGrid.Text = "Contact List";
            // 
            // dataGridContact
            // 
            this.dataGridContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.contactName,
            this.Address,
            this.Tel,
            this.Email,
            this.Type});
            this.dataGridContact.Location = new System.Drawing.Point(28, 30);
            this.dataGridContact.MultiSelect = false;
            this.dataGridContact.Name = "dataGridContact";
            this.dataGridContact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridContact.Size = new System.Drawing.Size(683, 242);
            this.dataGridContact.TabIndex = 0;
            this.dataGridContact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onGridCellClick);
            
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // contactName
            // 
            this.contactName.DataPropertyName = "Name";
            this.contactName.HeaderText = "Name";
            this.contactName.Name = "contactName";
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
            this.Tel.HeaderText = "Contact Number";
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactStatusStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1298, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // contactStatusStrip
            // 
            this.contactStatusStrip.Name = "contactStatusStrip";
            this.contactStatusStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // cmbType
            // 
            this.cmbType.DropDownHeight = 150;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.IntegralHeight = false;
            this.cmbType.ItemHeight = 13;
            this.cmbType.Location = new System.Drawing.Point(152, 250);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(250, 21);
            this.cmbType.TabIndex = 17;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(28, 298);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            
            // 
            // FormNewContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 421);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpContactGrid);
            this.Controls.Add(this.contactGroup);
            this.Name = "FormNewContact";
            this.Text = "New Contact";
            this.Load += new System.EventHandler(this.onContactFormLoad);
            this.contactGroup.ResumeLayout(false);
            this.contactGroup.PerformLayout();
            this.grpContactGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContact)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.GroupBox contactGroup;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.GroupBox grpContactGrid;
        private System.Windows.Forms.DataGridView dataGridContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel contactStatusStrip;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnSubmit;
    }
}