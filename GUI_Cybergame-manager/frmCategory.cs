using BUS_Cybergame_managers.Interface;
using BUS_Cybergame_managers;
using DTO_Cybergame_managers;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Untiliti;
namespace GUI_Cybergame_manager
{
    public partial class frmCategory : Form
    {
        ICategoryBUS ct = new CategoryBUS();
        ISupplierBUS supp = new SupplierBUS();
        private Guna2PictureBox currenpic;
        public frmCategory()
        {
            InitializeComponent();
        }
        private void clickImage(object senderPicItem)
        {
            currenpic = (Guna2PictureBox)senderPicItem;
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                currenpic.Image = Image.FromFile(openDlg.FileName);
                currenpic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            currenpic.Refresh();
        }
        private void imgItem_Click_1(object sender, EventArgs e)
        {
            clickImage(sender);
        }
        public void LoadData()
        {
            dgvSupliers.DataSource = supp.getAll();
            dgvFoodItem.Rows.Clear();
            foreach (Categorys e in ct.getAll())
            {
                int rowIndex = dgvFoodItem.Rows.Add(); // thêm một dòng mới và lấy chỉ số của dòng đó
                dgvFoodItem.Rows[rowIndex].Height = 75;
                DataGridViewRow row = dgvFoodItem.Rows[rowIndex];
                row.Cells["idItem"].Value = e.IDitem;
                row.Cells["nameItem"].Value = e.NameItem;
                row.Cells["idClassItem"].Value = e.IDClassItem;
                row.Cells["quantityItem"].Value = e.QuantityItem;
                row.Cells["dramItem"].Value = e.DramItem;
                row.Cells["priceItem"].Value = e.PriceItem;
                row.Cells["imageItem"].Value = e.ImageItem;
                
                
            }

        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmEmployee frm = Application.OpenForms.OfType<frmEmployee>().FirstOrDefault();
            //if (txtIdItem.Text == "" || txtNameItem.Text == "" || txt.Text == "" || txtBirthDay.Text == "" || txtPhoneNumber.Text == "")
            //{
            //    MessageBox.Show("Dữ liệu chưa đủ, vui lòng nhập lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            
                try
                {

                    MemoryStream stream = new MemoryStream();
                    // Lưu trữ hình ảnh vào MemoryStream
                    imgItem.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    // Chuyển đổi nội dung của MemoryStream thành một mảng byte
                    byte[] imageBytes = stream.ToArray();
                    int val = ct.Insert(new Categorys(Convert.ToInt32(txtIdItem.Text), txtNameItem.Text, Tool.PhanLoai(cbbIDClassItem.Text), Convert.ToInt32(txtQuantityItem.Text), txtDramItem.Text, Convert.ToDecimal(txtPrice.Text), imageBytes));
                    if (val == -1)
                        MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        MessageBox.Show("Đã thêm dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
                catch
                {
                    MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                int val = ct.Delete(int.Parse(dgvFoodItem[0, dgvFoodItem.CurrentCell.RowIndex].Value.ToString()));
                LoadData();
                if (val == -1)
                    MessageBox.Show("Xóa dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("Đã xóa dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddSupp_Click(object sender, EventArgs e)
        {
            try
            {
                int val = supp.Insert(new supplier(Convert.ToInt32(txtidSupp.Text), txtSuppName.Text));
                if (val == -1)
                    MessageBox.Show("Thêm dữ liệu không thành công, hãy kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("Đã thêm dữ liệu thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch
            {
                MessageBox.Show("Không thêm được dữ liệu, có thể do lỗi CSDL!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
