
namespace cw2.transaction
{
    partial class FormNewTransaction
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
            this.components = new System.ComponentModel.Container();
            this.groupAddEditTransaction = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.rBtnGroupType = new System.Windows.Forms.GroupBox();
            this.rBtnOneOff = new System.Windows.Forms.RadioButton();
            this.rBtnRecurrence = new System.Windows.Forms.RadioButton();
            this.rBtnGroupIncomeExpense = new System.Windows.Forms.GroupBox();
            this.rBtnExpense = new System.Windows.Forms.RadioButton();
            this.rBtnIncome = new System.Windows.Forms.RadioButton();
            this.dtpExpireDate = new System.Windows.Forms.DateTimePicker();
            this.cmbRecurrenceType = new System.Windows.Forms.ComboBox();
            this.txtTxnAmount = new System.Windows.Forms.TextBox();
            this.txtTxnTitle = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpireDate = new System.Windows.Forms.Label();
            this.lblRecurrenceType = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTxnDate = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblTxnTitle = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupAddEditTransaction.SuspendLayout();
            this.rBtnGroupType.SuspendLayout();
            this.rBtnGroupIncomeExpense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupAddEditTransaction
            // 
            this.groupAddEditTransaction.Controls.Add(this.btnReset);
            this.groupAddEditTransaction.Controls.Add(this.btnSave);
            this.groupAddEditTransaction.Controls.Add(this.lblMonth);
            this.groupAddEditTransaction.Controls.Add(this.cmbMonth);
            this.groupAddEditTransaction.Controls.Add(this.txtDay);
            this.groupAddEditTransaction.Controls.Add(this.rBtnGroupType);
            this.groupAddEditTransaction.Controls.Add(this.rBtnGroupIncomeExpense);
            this.groupAddEditTransaction.Controls.Add(this.dtpExpireDate);
            this.groupAddEditTransaction.Controls.Add(this.cmbRecurrenceType);
            this.groupAddEditTransaction.Controls.Add(this.txtTxnAmount);
            this.groupAddEditTransaction.Controls.Add(this.txtTxnTitle);
            this.groupAddEditTransaction.Controls.Add(this.dtpDate);
            this.groupAddEditTransaction.Controls.Add(this.lblExpireDate);
            this.groupAddEditTransaction.Controls.Add(this.lblRecurrenceType);
            this.groupAddEditTransaction.Controls.Add(this.lblAmount);
            this.groupAddEditTransaction.Controls.Add(this.lblTxnDate);
            this.groupAddEditTransaction.Controls.Add(this.lblDay);
            this.groupAddEditTransaction.Controls.Add(this.lblTxnTitle);
            this.groupAddEditTransaction.Location = new System.Drawing.Point(12, 12);
            this.groupAddEditTransaction.Name = "groupAddEditTransaction";
            this.groupAddEditTransaction.Size = new System.Drawing.Size(484, 469);
            this.groupAddEditTransaction.TabIndex = 1;
            this.groupAddEditTransaction.TabStop = false;
            this.groupAddEditTransaction.Text = "Add/Edit Transaction";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(299, 430);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onBtnResetClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(202, 430);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.onBtnSaveTransactionClick);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(87, 392);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 27;
            this.lblMonth.Text = "Month";
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(203, 389);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(108, 21);
            this.cmbMonth.TabIndex = 11;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(203, 351);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(108, 20);
            this.txtDay.TabIndex = 10;
            // 
            // rBtnGroupType
            // 
            this.rBtnGroupType.Controls.Add(this.rBtnOneOff);
            this.rBtnGroupType.Controls.Add(this.rBtnRecurrence);
            this.rBtnGroupType.Location = new System.Drawing.Point(203, 198);
            this.rBtnGroupType.Name = "rBtnGroupType";
            this.rBtnGroupType.Size = new System.Drawing.Size(199, 56);
            this.rBtnGroupType.TabIndex = 19;
            this.rBtnGroupType.TabStop = false;
            this.rBtnGroupType.Text = "Occurence";
            this.rBtnGroupType.UseCompatibleTextRendering = true;
            // 
            // rBtnOneOff
            // 
            this.rBtnOneOff.AutoSize = true;
            this.rBtnOneOff.Checked = true;
            this.rBtnOneOff.Location = new System.Drawing.Point(6, 16);
            this.rBtnOneOff.Name = "rBtnOneOff";
            this.rBtnOneOff.Size = new System.Drawing.Size(62, 17);
            this.rBtnOneOff.TabIndex = 6;
            this.rBtnOneOff.TabStop = true;
            this.rBtnOneOff.Text = "One-Off";
            this.rBtnOneOff.UseVisualStyleBackColor = true;
            this.rBtnOneOff.CheckedChanged += new System.EventHandler(this.onBtnOneOffChanged);
            // 
            // rBtnRecurrence
            // 
            this.rBtnRecurrence.AutoSize = true;
            this.rBtnRecurrence.Location = new System.Drawing.Point(90, 16);
            this.rBtnRecurrence.Name = "rBtnRecurrence";
            this.rBtnRecurrence.Size = new System.Drawing.Size(81, 17);
            this.rBtnRecurrence.TabIndex = 7;
            this.rBtnRecurrence.Text = "Recurrence";
            this.rBtnRecurrence.UseVisualStyleBackColor = true;
            this.rBtnRecurrence.CheckedChanged += new System.EventHandler(this.onrBtnRecurrenceChanged);
            // 
            // rBtnGroupIncomeExpense
            // 
            this.rBtnGroupIncomeExpense.Controls.Add(this.rBtnExpense);
            this.rBtnGroupIncomeExpense.Controls.Add(this.rBtnIncome);
            this.rBtnGroupIncomeExpense.Location = new System.Drawing.Point(202, 134);
            this.rBtnGroupIncomeExpense.Name = "rBtnGroupIncomeExpense";
            this.rBtnGroupIncomeExpense.Size = new System.Drawing.Size(200, 49);
            this.rBtnGroupIncomeExpense.TabIndex = 18;
            this.rBtnGroupIncomeExpense.TabStop = false;
            this.rBtnGroupIncomeExpense.Text = "Income/Expense";
            // 
            // rBtnExpense
            // 
            this.rBtnExpense.AutoSize = true;
            this.rBtnExpense.Location = new System.Drawing.Point(106, 19);
            this.rBtnExpense.Name = "rBtnExpense";
            this.rBtnExpense.Size = new System.Drawing.Size(66, 17);
            this.rBtnExpense.TabIndex = 5;
            this.rBtnExpense.Text = "Expense";
            this.rBtnExpense.UseVisualStyleBackColor = true;
            // 
            // rBtnIncome
            // 
            this.rBtnIncome.AutoSize = true;
            this.rBtnIncome.Checked = true;
            this.rBtnIncome.Location = new System.Drawing.Point(6, 19);
            this.rBtnIncome.Name = "rBtnIncome";
            this.rBtnIncome.Size = new System.Drawing.Size(60, 17);
            this.rBtnIncome.TabIndex = 4;
            this.rBtnIncome.TabStop = true;
            this.rBtnIncome.Text = "Income";
            this.rBtnIncome.UseVisualStyleBackColor = true;
            // 
            // dtpExpireDate
            // 
            this.dtpExpireDate.CustomFormat = "MM/dd/yyyy";
            this.dtpExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpireDate.Location = new System.Drawing.Point(202, 309);
            this.dtpExpireDate.Name = "dtpExpireDate";
            this.dtpExpireDate.Size = new System.Drawing.Size(109, 20);
            this.dtpExpireDate.TabIndex = 9;
            // 
            // cmbRecurrenceType
            // 
            this.cmbRecurrenceType.FormattingEnabled = true;
            this.cmbRecurrenceType.Location = new System.Drawing.Point(202, 269);
            this.cmbRecurrenceType.Name = "cmbRecurrenceType";
            this.cmbRecurrenceType.Size = new System.Drawing.Size(109, 21);
            this.cmbRecurrenceType.TabIndex = 8;
            this.cmbRecurrenceType.SelectedValueChanged += new System.EventHandler(this.onRecurrenceTypeChanged);
            // 
            // txtTxnAmount
            // 
            this.txtTxnAmount.Location = new System.Drawing.Point(202, 99);
            this.txtTxnAmount.Name = "txtTxnAmount";
            this.txtTxnAmount.Size = new System.Drawing.Size(109, 20);
            this.txtTxnAmount.TabIndex = 2;
            this.txtTxnAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onAmountKeyPress);
            // 
            // txtTxnTitle
            // 
            this.txtTxnTitle.Location = new System.Drawing.Point(202, 29);
            this.txtTxnTitle.Name = "txtTxnTitle";
            this.txtTxnTitle.Size = new System.Drawing.Size(200, 20);
            this.txtTxnTitle.TabIndex = 1;
            this.txtTxnTitle.Validating += new System.ComponentModel.CancelEventHandler(this.validateTitle);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "MM/dd/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(202, 63);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(109, 20);
            this.dtpDate.TabIndex = 2;
            // 
            // lblExpireDate
            // 
            this.lblExpireDate.AutoSize = true;
            this.lblExpireDate.Location = new System.Drawing.Point(65, 316);
            this.lblExpireDate.Name = "lblExpireDate";
            this.lblExpireDate.Size = new System.Drawing.Size(62, 13);
            this.lblExpireDate.TabIndex = 8;
            this.lblExpireDate.Text = "Expire Date";
            // 
            // lblRecurrenceType
            // 
            this.lblRecurrenceType.AutoSize = true;
            this.lblRecurrenceType.Location = new System.Drawing.Point(64, 272);
            this.lblRecurrenceType.Name = "lblRecurrenceType";
            this.lblRecurrenceType.Size = new System.Drawing.Size(90, 13);
            this.lblRecurrenceType.TabIndex = 6;
            this.lblRecurrenceType.Text = "Recurrence Type";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(81, 102);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount";
            // 
            // lblTxnDate
            // 
            this.lblTxnDate.AutoSize = true;
            this.lblTxnDate.Location = new System.Drawing.Point(97, 70);
            this.lblTxnDate.Name = "lblTxnDate";
            this.lblTxnDate.Size = new System.Drawing.Size(30, 13);
            this.lblTxnDate.TabIndex = 2;
            this.lblTxnDate.Text = "Date";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(97, 354);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(26, 13);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "Day";
            // 
            // lblTxnTitle
            // 
            this.lblTxnTitle.AutoSize = true;
            this.lblTxnTitle.Location = new System.Drawing.Point(97, 36);
            this.lblTxnTitle.Name = "lblTxnTitle";
            this.lblTxnTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTxnTitle.TabIndex = 0;
            this.lblTxnTitle.Text = "Title";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormNewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 502);
            this.Controls.Add(this.groupAddEditTransaction);
            this.Name = "FormNewTransaction";
            this.Text = "FormNewTransaction";
            this.Load += new System.EventHandler(this.onNewTransactionFormLoad);
            this.groupAddEditTransaction.ResumeLayout(false);
            this.groupAddEditTransaction.PerformLayout();
            this.rBtnGroupType.ResumeLayout(false);
            this.rBtnGroupType.PerformLayout();
            this.rBtnGroupIncomeExpense.ResumeLayout(false);
            this.rBtnGroupIncomeExpense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupAddEditTransaction;
        private System.Windows.Forms.ComboBox cmbRecurrenceType;
        private System.Windows.Forms.RadioButton rBtnRecurrence;
        private System.Windows.Forms.RadioButton rBtnOneOff;
        private System.Windows.Forms.TextBox txtTxnAmount;
        private System.Windows.Forms.TextBox txtTxnTitle;
        private System.Windows.Forms.RadioButton rBtnExpense;
        private System.Windows.Forms.RadioButton rBtnIncome;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblExpireDate;
        private System.Windows.Forms.Label lblRecurrenceType;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTxnDate;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblTxnTitle;
        private System.Windows.Forms.DateTimePicker dtpExpireDate;
        private System.Windows.Forms.GroupBox rBtnGroupIncomeExpense;
        private System.Windows.Forms.GroupBox rBtnGroupType;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}