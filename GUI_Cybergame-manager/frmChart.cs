using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Cybergame_manager
{
    public partial class frmChart : Form
    {
        public frmChart()
        {
            InitializeComponent();
            
        }

        private void frmChart_Load(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.AddXY("1", 1000);
            chart1.Series["Series1"].Points.AddXY("2", 500);
            chart1.Series["Series1"].Points.AddXY("3", 700);
            chart1.Series["Series1"].Points.AddXY("4", 1000);
            chart1.Series["Series1"].Points.AddXY("5", 700);
            chart1.Series["Series1"].Points.AddXY("6", 1000);

        }
    }
}
