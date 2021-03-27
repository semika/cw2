using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cw2.transaction;

namespace cw2
{
    public partial class frmExplorer : Form
    {
        public frmExplorer()
        {
            InitializeComponent();
        }

        private void onManageEventMenuItemClick(object sender, EventArgs e)
        {
            FormManageEvent formManageEvent = new FormManageEvent();
            formManageEvent.Show();

                     
        }

        private void onNewContactToolStripMenuItemClick(object sender, EventArgs e)
        {
            FormNewContact formNewContact = new FormNewContact();
            formNewContact.Show();
        }

        private void frmExplorer_Load(object sender, EventArgs e)
        {

        }

        private void onNewTransaactionToolStripMenuItemClick(object sender, EventArgs e)
        {
            FormNewTransaction formNewTransaction = new FormNewTransaction();
            formNewTransaction.Show();
        }
    }
}
