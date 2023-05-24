using BUS_Cybergame_managers;
using BUS_Cybergame_managers.Interface;
using DTO_Cybergame_managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Cybergame_manager
{
    public partial class frmShowEmployee : Form
    {
         IEmployeeBUS emb = new EmployeeBUS();
        public frmShowEmployee()
        {
            InitializeComponent();
        }

        private void frmShowEmployee_Load(object sender, EventArgs e)
        {
            Employee em = emb.getEmployee_ID(localVal.EMPID);
            
            txtEmployeeID.Text = em.IDEmployee.ToString();
            txtEmployeeName.Text = em.NameEmployee.ToString();
            txtEmployeePass.Text = em.PassEmp.ToString();
            txtBirthDay.Text = em.BirthEmp.ToString();
            txtPhoneNumber.Text = em.PhoneNumber.ToString();
            cbbSexual.Text = em.SexualEmp == true?"Nam":"Nữ";
            cbbPermission.Text = em.Permission.ToString();
            MemoryStream ms = new MemoryStream(em.ImageEmp.ToArray());
            imgEmployeeAva.Image = Image.FromStream(ms);
            imgEmployeeAva.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}
