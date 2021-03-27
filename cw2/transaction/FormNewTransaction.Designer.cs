
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
            this.groupTransactionDraft = new System.Windows.Forms.GroupBox();
            this.groupAddEditTransaction = new System.Windows.Forms.GroupBox();
            this.lblDayOfYearMonth = new System.Windows.Forms.Label();
            this.cmdMonthOfYear = new System.Windows.Forms.ComboBox();
            this.txtDayOfYear = new System.Windows.Forms.TextBox();
            this.lblDayOfYearDay = new System.Windows.Forms.Label();
            this.lblDayOfYear = new System.Windows.Forms.Label();
            this.txtDayOfMonth = new System.Windows.Forms.TextBox();
            this.lblDayOfMonthDay = new System.Windows.Forms.Label();
            this.cmbDayOfWeek = new System.Windows.Forms.ComboBox();
            this.rBtnGroupType = new System.Windows.Forms.GroupBox();
            this.rBtnOneOff = new System.Windows.Forms.RadioButton();
            this.rBtnRecurrence = new System.Windows.Forms.RadioButton();
            this.rBtnGroupIncomeExpense = new System.Windows.Forms.GroupBox();
            this.rBtnExpense = new System.Windows.Forms.RadioButton();
            this.rBtnIncome = new System.Windows.Forms.RadioButton();
            this.dtpExpireDate = new System.Windows.Forms.DateTimePicker();
            this.cmbOccurence = new System.Windows.Forms.ComboBox();
            this.txtTxnAmount = new System.Windows.Forms.TextBox();
            this.txtTxnTitle = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblExpireDate = new System.Windows.Forms.Label();
            this.lblDayOfWeek = new System.Windows.Forms.Label();
            this.lblOccurence = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTxnDate = new System.Windows.Forms.Label();
            this.lblDayOfMonth = new System.Windows.Forms.Label();
            this.lblTxnTitle = new System.Windows.Forms.Label();
            this.groupAddEditTransaction.SuspendLayout();
            this.rBtnGroupType.SuspendLayout();
            this.rBtnGroupIncomeExpense.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupTransactionDraft
            // 
            this.groupTransactionDraft.Location = new System.Drawing.Point(12, 21);
            this.groupTransactionDraft.Name = "groupTransactionDraft";
            this.groupTransactionDraft.Size = new System.Drawing.Size(722, 469);
            this.groupTransactionDraft.TabIndex = 0;
            this.groupTransactionDraft.TabStop = false;
            this.groupTransactionDraft.Text = "Draft Transactions";
            // 
            // groupAddEditTransaction
            // 
            this.groupAddEditTransaction.Controls.Add(this.lblDayOfYearMonth);
            this.groupAddEditTransaction.Controls.Add(this.cmdMonthOfYear);
            this.groupAddEditTransaction.Controls.Add(this.txtDayOfYear);
            this.groupAddEditTransaction.Controls.Add(this.lblDayOfYearDay);
            this.groupAddEditTransaction.Controls.Add(this.lblDayOfYear);
            this.groupAddEditTransaction.Controls.Add(this.txtDayOfMonth);
            this.groupAddEditTransaction.Controls.Add(this.lblDayOfMonthDay);
            this.groupAddEditTransaction.Controls.Add(this.cmbDayOfWeek);
            this.groupAddEditTransaction.Controls.Add(this.rBtnGroupType);
            this.groupAddEditTransaction.Controls.Add(this.rBtnGroupIncomeExpense);
            this.groupAddEditTransaction.Controls.Add(this.dtpExpireDate);
            this.groupAddEditTransaction.Controls.Add(this.cmbOccurence);
            this.groupAddEditTransaction.Controls.Add(this.txtTxnAmount);
            this.groupAddEditTransaction.Controls.Add(this.txtTxnTitle);
            this.groupAddEditTransaction.Controls.Add(this.dateTimePicker1);
            this.groupAddEditTransaction.Controls.Add(this.lblExpireDate);
            this.groupAddEditTransaction.Controls.Add(this.lblDayOfWeek);
            this.groupAddEditTransaction.Controls.Add(this.lblOccurence);
            this.groupAddEditTransaction.Controls.Add(this.lblAmount);
            this.groupAddEditTransaction.Controls.Add(this.lblTxnDate);
            this.groupAddEditTransaction.Controls.Add(this.lblDayOfMonth);
            this.groupAddEditTransaction.Controls.Add(this.lblTxnTitle);
            this.groupAddEditTransaction.Location = new System.Drawing.Point(758, 21);
            this.groupAddEditTransaction.Name = "groupAddEditTransaction";
            this.groupAddEditTransaction.Size = new System.Drawing.Size(484, 469);
            this.groupAddEditTransaction.TabIndex = 1;
            this.groupAddEditTransaction.TabStop = false;
            this.groupAddEditTransaction.Text = "Add/Edit Transaction";
            this.groupAddEditTransaction.Enter += new System.EventHandler(this.groupAddEditTransaction_Enter);
            // 
            // lblDayOfYearMonth
            // 
            this.lblDayOfYearMonth.AutoSize = true;
            this.lblDayOfYearMonth.Location = new System.Drawing.Point(280, 378);
            this.lblDayOfYearMonth.Name = "lblDayOfYearMonth";
            this.lblDayOfYearMonth.Size = new System.Drawing.Size(54, 13);
            this.lblDayOfYearMonth.TabIndex = 27;
            this.lblDayOfYearMonth.Text = "On Month";
            // 
            // cmdMonthOfYear
            // 
            this.cmdMonthOfYear.FormattingEnabled = true;
            this.cmdMonthOfYear.Location = new System.Drawing.Point(335, 373);
            this.cmdMonthOfYear.Name = "cmdMonthOfYear";
            this.cmdMonthOfYear.Size = new System.Drawing.Size(67, 21);
            this.cmdMonthOfYear.TabIndex = 26;
            // 
            // txtDayOfYear
            // 
            this.txtDayOfYear.Location = new System.Drawing.Point(203, 373);
            this.txtDayOfYear.Name = "txtDayOfYear";
            this.txtDayOfYear.Size = new System.Drawing.Size(49, 20);
            this.txtDayOfYear.TabIndex = 25;
            // 
            // lblDayOfYearDay
            // 
            this.lblDayOfYearDay.AutoSize = true;
            this.lblDayOfYearDay.Location = new System.Drawing.Point(151, 381);
            this.lblDayOfYearDay.Name = "lblDayOfYearDay";
            this.lblDayOfYearDay.Size = new System.Drawing.Size(43, 13);
            this.lblDayOfYearDay.TabIndex = 24;
            this.lblDayOfYearDay.Text = "On Day";
            // 
            // lblDayOfYear
            // 
            this.lblDayOfYear.AutoSize = true;
            this.lblDayOfYear.Location = new System.Drawing.Point(52, 381);
            this.lblDayOfYear.Name = "lblDayOfYear";
            this.lblDayOfYear.Size = new System.Drawing.Size(63, 13);
            this.lblDayOfYear.TabIndex = 23;
            this.lblDayOfYear.Text = "Day of Year";
            // 
            // txtDayOfMonth
            // 
            this.txtDayOfMonth.Location = new System.Drawing.Point(203, 347);
            this.txtDayOfMonth.Name = "txtDayOfMonth";
            this.txtDayOfMonth.Size = new System.Drawing.Size(49, 20);
            this.txtDayOfMonth.TabIndex = 22;
            // 
            // lblDayOfMonthDay
            // 
            this.lblDayOfMonthDay.AutoSize = true;
            this.lblDayOfMonthDay.Location = new System.Drawing.Point(151, 348);
            this.lblDayOfMonthDay.Name = "lblDayOfMonthDay";
            this.lblDayOfMonthDay.Size = new System.Drawing.Size(43, 13);
            this.lblDayOfMonthDay.TabIndex = 21;
            this.lblDayOfMonthDay.Text = "On Day";
            // 
            // cmbDayOfWeek
            // 
            this.cmbDayOfWeek.FormattingEnabled = true;
            this.cmbDayOfWeek.Location = new System.Drawing.Point(202, 305);
            this.cmbDayOfWeek.Name = "cmbDayOfWeek";
            this.cmbDayOfWeek.Size = new System.Drawing.Size(200, 21);
            this.cmbDayOfWeek.TabIndex = 20;
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
            this.rBtnGroupType.Text = "Type";
            // 
            // rBtnOneOff
            // 
            this.rBtnOneOff.AutoSize = true;
            this.rBtnOneOff.Checked = true;
            this.rBtnOneOff.Location = new System.Drawing.Point(6, 16);
            this.rBtnOneOff.Name = "rBtnOneOff";
            this.rBtnOneOff.Size = new System.Drawing.Size(62, 17);
            this.rBtnOneOff.TabIndex = 14;
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
            this.rBtnRecurrence.TabIndex = 15;
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
            this.rBtnExpense.TabIndex = 11;
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
            this.rBtnIncome.TabIndex = 10;
            this.rBtnIncome.TabStop = true;
            this.rBtnIncome.Text = "Income";
            this.rBtnIncome.UseVisualStyleBackColor = true;
            this.rBtnIncome.CheckedChanged += new System.EventHandler(this.rBtnIncome_CheckedChanged);
            // 
            // dtpExpireDate
            // 
            this.dtpExpireDate.CustomFormat = "MM/dd/yyyyy";
            this.dtpExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpireDate.Location = new System.Drawing.Point(202, 417);
            this.dtpExpireDate.Name = "dtpExpireDate";
            this.dtpExpireDate.Size = new System.Drawing.Size(109, 20);
            this.dtpExpireDate.TabIndex = 17;
            // 
            // cmbOccurence
            // 
            this.cmbOccurence.FormattingEnabled = true;
            this.cmbOccurence.Location = new System.Drawing.Point(202, 269);
            this.cmbOccurence.Name = "cmbOccurence";
            this.cmbOccurence.Size = new System.Drawing.Size(200, 21);
            this.cmbOccurence.TabIndex = 16;
            // 
            // txtTxnAmount
            // 
            this.txtTxnAmount.Location = new System.Drawing.Point(202, 99);
            this.txtTxnAmount.Name = "txtTxnAmount";
            this.txtTxnAmount.Size = new System.Drawing.Size(200, 20);
            this.txtTxnAmount.TabIndex = 13;
            // 
            // txtTxnTitle
            // 
            this.txtTxnTitle.Location = new System.Drawing.Point(202, 29);
            this.txtTxnTitle.Name = "txtTxnTitle";
            this.txtTxnTitle.Size = new System.Drawing.Size(200, 20);
            this.txtTxnTitle.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(202, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // lblExpireDate
            // 
            this.lblExpireDate.AutoSize = true;
            this.lblExpireDate.Location = new System.Drawing.Point(62, 424);
            this.lblExpireDate.Name = "lblExpireDate";
            this.lblExpireDate.Size = new System.Drawing.Size(62, 13);
            this.lblExpireDate.TabIndex = 8;
            this.lblExpireDate.Text = "Expire Date";
            // 
            // lblDayOfWeek
            // 
            this.lblDayOfWeek.AutoSize = true;
            this.lblDayOfWeek.Location = new System.Drawing.Point(52, 305);
            this.lblDayOfWeek.Name = "lblDayOfWeek";
            this.lblDayOfWeek.Size = new System.Drawing.Size(72, 13);
            this.lblDayOfWeek.TabIndex = 7;
            this.lblDayOfWeek.Text = "Day Of Week";
            // 
            // lblOccurence
            // 
            this.lblOccurence.AutoSize = true;
            this.lblOccurence.Location = new System.Drawing.Point(64, 272);
            this.lblOccurence.Name = "lblOccurence";
            this.lblOccurence.Size = new System.Drawing.Size(60, 13);
            this.lblOccurence.TabIndex = 6;
            this.lblOccurence.Text = "Occurence";
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
            // lblDayOfMonth
            // 
            this.lblDayOfMonth.AutoSize = true;
            this.lblDayOfMonth.Location = new System.Drawing.Point(51, 348);
            this.lblDayOfMonth.Name = "lblDayOfMonth";
            this.lblDayOfMonth.Size = new System.Drawing.Size(73, 13);
            this.lblDayOfMonth.TabIndex = 1;
            this.lblDayOfMonth.Text = "Day Of Month";
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
            // FormNewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 502);
            this.Controls.Add(this.groupAddEditTransaction);
            this.Controls.Add(this.groupTransactionDraft);
            this.Name = "FormNewTransaction";
            this.Text = "FormNewTransaction";
            this.Load += new System.EventHandler(this.onNewTransactionFormLoad);
            this.groupAddEditTransaction.ResumeLayout(false);
            this.groupAddEditTransaction.PerformLayout();
            this.rBtnGroupType.ResumeLayout(false);
            this.rBtnGroupType.PerformLayout();
            this.rBtnGroupIncomeExpense.ResumeLayout(false);
            this.rBtnGroupIncomeExpense.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTransactionDraft;
        private System.Windows.Forms.GroupBox groupAddEditTransaction;
        private System.Windows.Forms.ComboBox cmbOccurence;
        private System.Windows.Forms.RadioButton rBtnRecurrence;
        private System.Windows.Forms.RadioButton rBtnOneOff;
        private System.Windows.Forms.TextBox txtTxnAmount;
        private System.Windows.Forms.TextBox txtTxnTitle;
        private System.Windows.Forms.RadioButton rBtnExpense;
        private System.Windows.Forms.RadioButton rBtnIncome;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblExpireDate;
        private System.Windows.Forms.Label lblDayOfWeek;
        private System.Windows.Forms.Label lblOccurence;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTxnDate;
        private System.Windows.Forms.Label lblDayOfMonth;
        private System.Windows.Forms.Label lblTxnTitle;
        private System.Windows.Forms.DateTimePicker dtpExpireDate;
        private System.Windows.Forms.GroupBox rBtnGroupIncomeExpense;
        private System.Windows.Forms.GroupBox rBtnGroupType;
        private System.Windows.Forms.ComboBox cmbDayOfWeek;
        private System.Windows.Forms.TextBox txtDayOfMonth;
        private System.Windows.Forms.Label lblDayOfMonthDay;
        private System.Windows.Forms.TextBox txtDayOfYear;
        private System.Windows.Forms.Label lblDayOfYearDay;
        private System.Windows.Forms.Label lblDayOfYear;
        private System.Windows.Forms.ComboBox cmdMonthOfYear;
        private System.Windows.Forms.Label lblDayOfYearMonth;
    }
}