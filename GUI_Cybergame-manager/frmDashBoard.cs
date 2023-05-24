using BUS_Cybergame_managers;
using BUS_Cybergame_managers.Interface;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace GUI_Cybergame_manager
{
    public partial class frmDashBoard : Form
    {
        IEmployeeBUS emb = new EmployeeBUS();
        private static int idEmployee;
        private int test = 0;
        public static int IDemployee
        {
            get { return idEmployee; }
            set { idEmployee = value; }
        }

        public frmDashBoard()
        {
            InitializeComponent();
            lbPermission.Text = emb.getEmployee_ID(localVal.EMPID).Permission;
            lbName.Location = new Point(lbPermission.Location.X + lbPermission.Width + 10, 12);
            lbName.Text = emb.getEmployee_ID(localVal.EMPID).NameEmployee;
            MemoryStream ms = new MemoryStream(emb.getEmployee_ID(localVal.EMPID).ImageEmp);
            Image image = Image.FromStream(ms);
            imgAdmin.Image = image;
            imgAdmin.SizeMode = PictureBoxSizeMode.StretchImage;
            imgAdmin.Location = new Point(lbName.Location.X + lbName.Width + 10, 12);
        }

        public void renderList()
        {
            Guna2Panel pnComputer = new Guna2Panel();
            pnComputer.Size = new Size(192,194);
            pnComputer.FillColor = Color.FromArgb(87, 108, 188);
            pnComputer.BorderRadius = 15;
            pnComputer.Controls.Add(new Guna2Button()
            {
                Text = $"PC {test+=1}",
                Size = new Size(40, 25),
                BorderRadius = 10,
                BackColor = Color.Transparent,
                Location = new Point(17, 12),
                FillColor = Color.FromArgb(165, 215, 232),
                ForeColor = Color.Black,
                Enabled = false

            }); ;
            pnComputer.Controls.Add(new Guna2HtmlLabel()
            {
                Text = "User :",
                ForeColor = Color.Silver,
                Font = new Font("Microsoft Sans Serif",12,FontStyle.Bold),
                Location = new Point(17, 70)

            });
            pnComputer.Controls.Add(new Guna2HtmlLabel()
            {
                Text = "Timeless :",
                ForeColor = Color.Silver,
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                Location = new Point(17, 125)

            });
            pnComputer.Controls.Add(new Guna2HtmlLabel()
            {
                Text = "Hazard149",
                ForeColor = Color.White,
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                Location = new Point(67, 70)

            });
            pnComputer.Controls.Add(new Guna2HtmlLabel()
            {
                Text = "2h30p",
                ForeColor = Color.White,
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                Location = new Point(101, 125)

            });
            flComputerList.Controls.Add(pnComputer);
            pnComputer.Click += PnComputer_Click;
        }

        private void PnComputer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tạo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pnComputer_Click(object sender, EventArgs e)
        {
            

        }

        private void txtAddcomputer_Click(object sender, EventArgs e)
        {
            renderList();
        }
    }
}
