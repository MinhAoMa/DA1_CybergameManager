using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Cybergame_users
{
    public partial class frmMaintUser : Form
    {
        public frmMaintUser()
        {
            InitializeComponent();
        }

        private void frmMaintUser_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);

        }

        private void imgMessage_Click(object sender, EventArgs e)
        {
            frmMessage frm = new frmMessage();
            frm.Show();
        }

        private void imgMenuOrder_Click(object sender, EventArgs e)
        {
            frmMenuOrder frm = new frmMenuOrder();
            frm.Show();
        }
    }
}
