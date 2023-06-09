﻿using BUS_Cybergame_managers.Interface;
using BUS_Cybergame_managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Cybergame_managers;
using Guna.UI2.WinForms;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using Microsoft.VisualBasic.Devices;
using System.Xml.Linq;

namespace GUI_Cybergame_users
{
    
    public partial class frmMenuOrder : Form
    {
       
        ICategoryBUS ct = new CategoryBUS();
        public List<Categorys> lct = new List<Categorys>();
        public frmMenuOrder()
        {
            InitializeComponent();
        }
        //int idItem,string nameItem,int idClassItem,int quantityItem,string dramitem,decimal priceItem, byte[] imageItem
        public Guna2GradientPanel renderItem(int idItem,string nameItem, decimal priceItem, byte[]imageItem)
        {
            Guna2GradientPanel pnItem = new Guna2GradientPanel();
            MemoryStream ms = new MemoryStream(imageItem);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
            pnItem.Size = new Size(200, 180);
            pnItem.FillColor = Color.SkyBlue;
            pnItem.FillColor2 = Color.DeepSkyBlue;
            pnItem.BorderRadius = 15;
            pnItem.Margin = new Padding(30, 30, 30, 30);
            pnItem.Controls.Add(new Guna2PictureBox()
            {
                Tag = "img",
                Size = new Size(142, 98),
                Location = new Point(27, 21),
                Image = image,
                SizeMode = PictureBoxSizeMode.StretchImage

            }); 
            pnItem.Controls.Add(new Guna2HtmlLabel()
            {
                Tag = "id",
                Text = idItem.ToString(),
                Location = new Point(16,18),
                Anchor = AnchorStyles.Left | AnchorStyles.Right,

            });
            pnItem.Controls.Add(new Guna2HtmlLabel()
            {
                Tag = "name",
                Text = nameItem,
                AutoSize = false,  // set AutoSize = false to customize the size of the label
                Size = new Size(142, 28),  // set the size of the label to fit the picture box
                Location = new Point(pnItem.Width / 2 - 30, 129),
                Anchor = AnchorStyles.Left | AnchorStyles.Right,

            });
            pnItem.Controls.Add(new Guna2HtmlLabel()
            {

                Tag = "price",
                Text = priceItem.ToString(),
                AutoSize = false,  // set AutoSize = false to customize the size of the label
                Size = new Size(142, 28),  // set the size of the label to fit the picture box
                Location = new Point(pnItem.Width / 2 - 30, 155),
                Anchor = AnchorStyles.Left | AnchorStyles.Right,

            });
            pnItem.Click += PnItem_Click;
            foreach (Control control in pnItem.Controls)
            {
                control.Click += (sender, e) =>
                {
                    renderOrderlist(idItem,nameItem, imageItem, priceItem);
                };
            }
            return pnItem;
            
        }
        private void PnItem_Click(object sender, EventArgs e)
        {
            Guna2GradientPanel pnItem = (Guna2GradientPanel)sender;
            Guna2HtmlLabel labelid = pnItem.Controls.OfType<Guna2HtmlLabel>().FirstOrDefault(control => control.Tag == "id");
            Guna2PictureBox ptItem = pnItem.Controls.OfType<Guna2PictureBox>().FirstOrDefault(control => control.Tag == "img");
            Guna2HtmlLabel labelName = pnItem.Controls.OfType<Guna2HtmlLabel>().FirstOrDefault(control => control.Tag == "name");
            Guna2HtmlLabel labelPrice = pnItem.Controls.OfType<Guna2HtmlLabel>().FirstOrDefault(control => control.Tag == "price");
            MemoryStream stream = new MemoryStream();
            // Lưu trữ hình ảnh vào MemoryStream
            ptItem.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            // Chuyển đổi nội dung của MemoryStream thành một mảng byte
            byte[] imageBytes = stream.ToArray();
            if (ptItem != null && labelName != null && labelPrice != null && labelid != null)
            {
                int id = Convert.ToInt32(labelid.Text);
                byte[] img = imageBytes;
                string name = labelName.Text;
                decimal price = Convert.ToDecimal(labelPrice.Text);
                renderOrderlist(id,name, imageBytes, price);

            }

        }
        public void renderOrderlist(int idItem,string nameItem, byte[] imageItem,decimal priceItem)
        {
            Guna2GradientPanel pnItem = new Guna2GradientPanel();
            MemoryStream ms = new MemoryStream(imageItem);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
            pnItem.Size = new Size(319, 76);
            pnItem.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pnItem.BorderThickness = 1;
            pnItem.BorderColor = Color.DarkGray;
            pnItem.Margin = new Padding(15, 15, 15, 15);
            pnItem.BackColor = Color.SkyBlue;
            pnItem.Controls.Add(new Guna2PictureBox()
            {
                Size = new Size(73, 49),
                Image = image,
                Location = new Point(22, 14),
                SizeMode = PictureBoxSizeMode.StretchImage

            });
            pnItem.Controls.Add(new Guna2HtmlLabel()
            {
                Text = nameItem,
                Location = new Point(130, 23),
                Anchor = AnchorStyles.Left | AnchorStyles.Right,
                Margin = new Padding(0,0,0,10)

            });
            pnItem.Controls.Add(new Guna2HtmlLabel()
            {
                Text = priceItem.ToString(),
                Location = new Point(115, 44),
                Anchor = AnchorStyles.Left | AnchorStyles.Right,

            });
            pnItem.Controls.Add(new Guna2HtmlLabel()
            {
                Text = idItem.ToString(),
                Location = new Point(115, 23),
                Anchor = AnchorStyles.Left | AnchorStyles.Right,

            });
            pnItem.Controls.Add(new Guna2HtmlLabel()
            {
                Text = "0",
                Location = new Point(250, 23),
                Anchor = AnchorStyles.Left | AnchorStyles.Right,

            });
            pnItem.Controls.Add(new Guna2Button()
            {
                Text = "+",
                Size = new Size(27, 19),
                Location = new Point(262, 44),
                Anchor = AnchorStyles.Left | AnchorStyles.Right,

            });
            pnItem.Controls.Add(new Guna2Button()
            {
                Text = "-",
                Size = new Size(27, 19),
                Location = new Point(220, 44),
                Anchor = AnchorStyles.Left | AnchorStyles.Right,
                

            });

            flOrderlist.Controls.Add(pnItem);
            Guna2HtmlLabel labelQuantity = pnItem.Controls.OfType<Guna2HtmlLabel>().FirstOrDefault(control => control.Location == new Point(250, 23));
            
            foreach (Control ct in pnItem.Controls)
            {
                if (ct is Guna2Button button)
                {
                    if (button.Text == "+")
                    {
                        button.Click += (sender, e) =>
                        {
                           
                            if (labelQuantity != null)
                            {
                                int quantity = Convert.ToInt32(labelQuantity.Text);
                                labelQuantity.Text = Convert.ToString(quantity + 1);
                            }
                        };
                    }
                    else if (button.Text == "-")
                    {
                        button.Click += (sender, e) =>
                        {
                           
                            if (labelQuantity != null)
                            {
                                int quantity = Convert.ToInt32(labelQuantity.Text);
                                labelQuantity.Text = Convert.ToString(quantity - 1);
                                if(quantity == 0)
                                {
                                    labelQuantity.Text = "0";
                                } 
                            }
                        };
                    }
                }
            }

        }
        public void LoadData()
        {

            foreach (Categorys e in ct.getAll())
            {
                
                lct.Add(e);
                if(e.IDClassItem == 1)
                {
                    flFoodlist.Controls.Add(renderItem(e.IDitem,e.NameItem,e.PriceItem, e.ImageItem));
                }
                else if (e.IDClassItem == 2)
                {
                    flDrinkList.Controls.Add(renderItem(e.IDitem, e.NameItem, e.PriceItem, e.ImageItem));
                }
                else
                {
                    flCardlist.Controls.Add(renderItem(e.IDitem, e.NameItem, e.PriceItem, e.ImageItem));
                }
                
            }
        }

        private void frmMenuOrder_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
