
namespace cw2
{
    partial class frmExplorer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklyEventViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTransaactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklyTransactionViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.contactsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eventToolStripMenuItem
            // 
            this.eventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageEventToolStripMenuItem,
            this.newEventToolStripMenuItem,
            this.weeklyEventViewToolStripMenuItem});
            this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            this.eventToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.eventToolStripMenuItem.Text = "Events";
            // 
            // manageEventToolStripMenuItem
            // 
            this.manageEventToolStripMenuItem.Name = "manageEventToolStripMenuItem";
            this.manageEventToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.manageEventToolStripMenuItem.Text = "Manage Event";
            this.manageEventToolStripMenuItem.Click += new System.EventHandler(this.onManageEventMenuItemClick);
            // 
            // newEventToolStripMenuItem
            // 
            this.newEventToolStripMenuItem.Name = "newEventToolStripMenuItem";
            this.newEventToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.newEventToolStripMenuItem.Text = "New Event";
            // 
            // weeklyEventViewToolStripMenuItem
            // 
            this.weeklyEventViewToolStripMenuItem.Name = "weeklyEventViewToolStripMenuItem";
            this.weeklyEventViewToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.weeklyEventViewToolStripMenuItem.Text = "Weekly View";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageTransactionToolStripMenuItem,
            this.newTransaactionToolStripMenuItem,
            this.weeklyTransactionViewToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.transactionToolStripMenuItem.Text = "Transactions";
            // 
            // manageTransactionToolStripMenuItem
            // 
            this.manageTransactionToolStripMenuItem.Name = "manageTransactionToolStripMenuItem";
            this.manageTransactionToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.manageTransactionToolStripMenuItem.Text = "Manage Transaction";
            this.manageTransactionToolStripMenuItem.Click += new System.EventHandler(this.onManageTransactionToolStripMenuItemClick);
            // 
            // newTransaactionToolStripMenuItem
            // 
            this.newTransaactionToolStripMenuItem.Name = "newTransaactionToolStripMenuItem";
            this.newTransaactionToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.newTransaactionToolStripMenuItem.Text = "New Transaaction";
            this.newTransaactionToolStripMenuItem.Click += new System.EventHandler(this.onNewTransaactionToolStripMenuItemClick);
            // 
            // weeklyTransactionViewToolStripMenuItem
            // 
            this.weeklyTransactionViewToolStripMenuItem.Name = "weeklyTransactionViewToolStripMenuItem";
            this.weeklyTransactionViewToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.weeklyTransactionViewToolStripMenuItem.Text = "Weekly View";
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageContactToolStripMenuItem,
            this.newContactToolStripMenuItem});
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.contactsToolStripMenuItem.Text = "Contacts";
            // 
            // manageContactToolStripMenuItem
            // 
            this.manageContactToolStripMenuItem.Name = "manageContactToolStripMenuItem";
            this.manageContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.manageContactToolStripMenuItem.Text = "Manage Contact";
            // 
            // newContactToolStripMenuItem
            // 
            this.newContactToolStripMenuItem.Name = "newContactToolStripMenuItem";
            this.newContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.newContactToolStripMenuItem.Text = "New Contact";
            this.newContactToolStripMenuItem.Click += new System.EventHandler(this.onNewContactToolStripMenuItemClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmExplorer";
            this.Text = "Explorer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmExplorer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weeklyEventViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTransaactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weeklyTransactionViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newContactToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

