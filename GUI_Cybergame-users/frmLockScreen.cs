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
    public partial class frmLockScreen : Form
    {
        public frmLockScreen()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            frmLoginUser frm = new frmLoginUser();
            frm.Show();
        }
    }
}
