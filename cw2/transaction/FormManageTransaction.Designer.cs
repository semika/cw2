
namespace cw2.transaction
{
    partial class FormManageTransaction
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
            this.groupBoxTransactionSearch = new System.Windows.Forms.GroupBox();
            this.groupBoxTransactionDataGrid = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dataGridTransaction = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Occurence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBoxTransactionSearch.SuspendLayout();
            this.groupBoxTransactionDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTransactionSearch
            // 
            this.groupBoxTransactionSearch.Controls.Add(this.btnReset);
            this.groupBoxTransactionSearch.Controls.Add(this.btnSearch);
            this.groupBoxTransactionSearch.Controls.Add(this.lblTitle);
            this.groupBoxTransactionSearch.Controls.Add(this.txtTitle);
            this.groupBoxTransactionSearch.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTransactionSearch.Name = "groupBoxTransactionSearch";
            this.groupBoxTransactionSearch.Size = new System.Drawing.Size(1188, 114);
            this.groupBoxTransactionSearch.TabIndex = 0;
            this.groupBoxTransactionSearch.TabStop = false;
            this.groupBoxTransactionSearch.Text = "Search Transaction";
            // 
            // groupBoxTransactionDataGrid
            // 
            this.groupBoxTransactionDataGrid.Controls.Add(this.btnDelete);
            this.groupBoxTransactionDataGrid.Controls.Add(this.btnEdit);
            this.groupBoxTransactionDataGrid.Controls.Add(this.dataGridTransaction);
            this.groupBoxTransactionDataGrid.Location = new System.Drawing.Point(12, 143);
            this.groupBoxTransactionDataGrid.Name = "groupBoxTransactionDataGrid";
            this.groupBoxTransactionDataGrid.Size = new System.Drawing.Size(1200, 353);
            this.groupBoxTransactionDataGrid.TabIndex = 1;
            this.groupBoxTransactionDataGrid.TabStop = false;
            this.groupBoxTransactionDataGrid.Text = "Transaction List";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(96, 29);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(260, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(29, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Titile";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(23, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.onBtnSearchClick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(128, 75);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Clear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.onBtnResetClick);
            // 
            // dataGridTransaction
            // 
            this.dataGridTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Titile,
            this.Amount,
            this.Date,
            this.Type,
            this.Occurence});
            this.dataGridTransaction.Location = new System.Drawing.Point(6, 19);
            this.dataGridTransaction.Name = "dataGridTransaction";
            this.dataGridTransaction.Size = new System.Drawing.Size(1164, 278);
            this.dataGridTransaction.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Titile
            // 
            this.Titile.DataPropertyName = "Title";
            this.Titile.HeaderText = "Title";
            this.Titile.Name = "Titile";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Occurence
            // 
            this.Occurence.DataPropertyName = "Occurence";
            this.Occurence.HeaderText = "Occurence";
            this.Occurence.Name = "Occurence";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(6, 315);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.onBtnEditClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(109, 315);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.onBtnDeleteClick);
            // 
            // FormManageTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 534);
            this.Controls.Add(this.groupBoxTransactionDataGrid);
            this.Controls.Add(this.groupBoxTransactionSearch);
            this.Name = "FormManageTransaction";
            this.Text = "ManageTransaction";
            this.groupBoxTransactionSearch.ResumeLayout(false);
            this.groupBoxTransactionSearch.PerformLayout();
            this.groupBoxTransactionDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTransactionSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.GroupBox groupBoxTransactionDataGrid;
        private System.Windows.Forms.DataGridView dataGridTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Occurence;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}