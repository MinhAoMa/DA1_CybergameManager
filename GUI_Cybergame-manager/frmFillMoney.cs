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
using Entities;
using BUS_Cybergame_managers.Interface;
using BUS_Cybergame_managers;
using Untiliti;
namespace GUI_Cybergame_manager
{
    public partial class frmFillMoney : Form
    {
        ICustomer mbs = new CustomerBUS();
        private string TxtIDCustomer;
        private string TxtCustomerAcc;
        private string TxtMoneyRemaint;
        private string TxttimeLeft;
        public string TXTIDCUSTOMER {
            get { return TxtIDCustomer; }
            set { TxtIDCustomer = value; }
        }
        public string TXTCUSTOMERACC
        {
            get { return TxtCustomerAcc; }
            set { TxtCustomerAcc = value; }
        }
        public string TXTMONEYREMAINT
        {
            get { return TxtMoneyRemaint; }
            set { TxtMoneyRemaint = value; }
        }
        public string TXTTIMELEFT
        {
            get { return TxttimeLeft; }
            set { TxttimeLeft = value; }
        }
        public frmFillMoney()
        {
            InitializeComponent();
        }

        private void frmFillMoney_Load(object sender, EventArgs e)
        {
            txtCustomerID.Text = TxtIDCustomer;
            txtCustomerAcc.Text = TxtCustomerAcc;
            txtMoneyRemaint.Text = TxtMoneyRemaint;
            txtLeftTime.Text = TxttimeLeft;
        }

        private void btnConfirmFill_Click(object sender, EventArgs e)
        {
            Customer mb = new Customer();
            frmCustommer frmCustomer = Application.OpenForms.OfType<frmCustommer>().FirstOrDefault();
            if (txtFillMoney.Text == "")
            {
                MessageBox.Show("Dữ liệu chưa đủ, vui lòng nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                mb.IDCustomer = Convert.ToInt32(txtCustomerID.Text);
                mb.NameCustomer = txtCustomerAcc.Text;
                mb.MoneyCus = Convert.ToDecimal(txtMoneyRemaint.Text) + Convert.ToDecimal(txtFillMoney.Text);
                mb.TimeLeftCus = Tool.QuyDoiGia(Convert.ToDecimal(txtMoneyRemaint.Text) + Convert.ToDecimal(txtFillMoney.Text));
                try
                {
                    int val = mbs.UpdateMoney(mb);

                    if (val == -1)
                        MessageBox.Show("Nạp không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        MessageBox.Show("Nạp thành công", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (frmCustomer != null)
                        {
                            // Gọi sự kiện Load của frmCustomer
                            frmCustomer.frmCustommer_Load(sender, e);
                            this.Close();
                        }  
                    }
                }
                catch
                {
                    MessageBox.Show("Không sửa được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           
        }
    }
}
