namespace GUI_Cybergame_manager
{
    partial class frmDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashBoard));
            this.pnDashBoardMaint = new Guna.UI2.WinForms.Guna2Panel();
            this.pnDashBoardManager = new Guna.UI2.WinForms.Guna2Panel();
            this.flComputerList = new System.Windows.Forms.FlowLayoutPanel();
            this.cbbSort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbFloors = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnOverview = new Guna.UI2.WinForms.Guna2Panel();
            this.lbName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.imgAdmin = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbPermission = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnCustomerView = new Guna.UI2.WinForms.Guna2Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.txtAddcomputer = new Guna.UI2.WinForms.Guna2Button();
            this.pnDashBoardMaint.SuspendLayout();
            this.pnDashBoardManager.SuspendLayout();
            this.pnOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDashBoardMaint
            // 
            this.pnDashBoardMaint.Controls.Add(this.pnDashBoardManager);
            this.pnDashBoardMaint.Controls.Add(this.pnOverview);
            this.pnDashBoardMaint.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnDashBoardMaint.Location = new System.Drawing.Point(0, 0);
            this.pnDashBoardMaint.Name = "pnDashBoardMaint";
            this.pnDashBoardMaint.ShadowDecoration.Parent = this.pnDashBoardMaint;
            this.pnDashBoardMaint.Size = new System.Drawing.Size(1129, 866);
            this.pnDashBoardMaint.TabIndex = 0;
            // 
            // pnDashBoardManager
            // 
            this.pnDashBoardManager.Controls.Add(this.txtAddcomputer);
            this.pnDashBoardManager.Controls.Add(this.flComputerList);
            this.pnDashBoardManager.Controls.Add(this.cbbSort);
            this.pnDashBoardManager.Controls.Add(this.cbbFloors);
            this.pnDashBoardManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDashBoardManager.Location = new System.Drawing.Point(0, 126);
            this.pnDashBoardManager.Name = "pnDashBoardManager";
            this.pnDashBoardManager.ShadowDecoration.Parent = this.pnDashBoardManager;
            this.pnDashBoardManager.Size = new System.Drawing.Size(1129, 740);
            this.pnDashBoardManager.TabIndex = 1;
            // 
            // flComputerList
            // 
            this.flComputerList.AutoScroll = true;
            this.flComputerList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.flComputerList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flComputerList.Location = new System.Drawing.Point(52, 96);
            this.flComputerList.Name = "flComputerList";
            this.flComputerList.Size = new System.Drawing.Size(1012, 530);
            this.flComputerList.TabIndex = 4;
            // 
            // cbbSort
            // 
            this.cbbSort.BackColor = System.Drawing.Color.Transparent;
            this.cbbSort.BorderRadius = 5;
            this.cbbSort.BorderThickness = 0;
            this.cbbSort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(109)))));
            this.cbbSort.FocusedColor = System.Drawing.Color.Empty;
            this.cbbSort.FocusedState.Parent = this.cbbSort;
            this.cbbSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbSort.ForeColor = System.Drawing.Color.White;
            this.cbbSort.FormattingEnabled = true;
            this.cbbSort.HoverState.Parent = this.cbbSort;
            this.cbbSort.ItemHeight = 30;
            this.cbbSort.Items.AddRange(new object[] {
            "Tầng 1",
            "Tầng 2",
            "Tầng 3"});
            this.cbbSort.ItemsAppearance.Parent = this.cbbSort;
            this.cbbSort.Location = new System.Drawing.Point(232, 32);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.ShadowDecoration.Parent = this.cbbSort;
            this.cbbSort.Size = new System.Drawing.Size(140, 36);
            this.cbbSort.TabIndex = 1;
            // 
            // cbbFloors
            // 
            this.cbbFloors.BackColor = System.Drawing.Color.Transparent;
            this.cbbFloors.BorderRadius = 5;
            this.cbbFloors.BorderThickness = 0;
            this.cbbFloors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbFloors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFloors.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(109)))));
            this.cbbFloors.FocusedColor = System.Drawing.Color.Empty;
            this.cbbFloors.FocusedState.Parent = this.cbbFloors;
            this.cbbFloors.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbFloors.ForeColor = System.Drawing.Color.White;
            this.cbbFloors.FormattingEnabled = true;
            this.cbbFloors.HoverState.Parent = this.cbbFloors;
            this.cbbFloors.ItemHeight = 30;
            this.cbbFloors.Items.AddRange(new object[] {
            "Tầng 1",
            "Tầng 2",
            "Tầng 3"});
            this.cbbFloors.ItemsAppearance.Parent = this.cbbFloors;
            this.cbbFloors.Location = new System.Drawing.Point(52, 32);
            this.cbbFloors.Name = "cbbFloors";
            this.cbbFloors.ShadowDecoration.Parent = this.cbbFloors;
            this.cbbFloors.Size = new System.Drawing.Size(140, 36);
            this.cbbFloors.TabIndex = 0;
            // 
            // pnOverview
            // 
            this.pnOverview.Controls.Add(this.lbName);
            this.pnOverview.Controls.Add(this.guna2HtmlLabel10);
            this.pnOverview.Controls.Add(this.guna2HtmlLabel11);
            this.pnOverview.Controls.Add(this.guna2HtmlLabel8);
            this.pnOverview.Controls.Add(this.guna2HtmlLabel9);
            this.pnOverview.Controls.Add(this.guna2HtmlLabel6);
            this.pnOverview.Controls.Add(this.guna2HtmlLabel7);
            this.pnOverview.Controls.Add(this.guna2HtmlLabel4);
            this.pnOverview.Controls.Add(this.guna2HtmlLabel5);
            this.pnOverview.Controls.Add(this.guna2HtmlLabel3);
            this.pnOverview.Controls.Add(this.guna2HtmlLabel2);
            this.pnOverview.Controls.Add(this.imgAdmin);
            this.pnOverview.Controls.Add(this.lbPermission);
            this.pnOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnOverview.ForeColor = System.Drawing.Color.White;
            this.pnOverview.Location = new System.Drawing.Point(0, 0);
            this.pnOverview.Name = "pnOverview";
            this.pnOverview.ShadowDecoration.Parent = this.pnOverview;
            this.pnOverview.Size = new System.Drawing.Size(1129, 126);
            this.pnOverview.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(135, 12);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(71, 35);
            this.lbName.TabIndex = 12;
            this.lbName.Text = "minh";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(1024, 83);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(39, 23);
            this.guna2HtmlLabel10.TabIndex = 11;
            this.guna2HtmlLabel10.Text = "2000";
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.Silver;
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(889, 83);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(129, 23);
            this.guna2HtmlLabel11.TabIndex = 10;
            this.guna2HtmlLabel11.Text = "Active members:";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(19)))), ((int)(((byte)(18)))));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(636, 83);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(47, 23);
            this.guna2HtmlLabel8.TabIndex = 9;
            this.guna2HtmlLabel8.Text = "10 PC";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.Silver;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(520, 83);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(110, 23);
            this.guna2HtmlLabel9.TabIndex = 8;
            this.guna2HtmlLabel9.Text = "Disconnected:";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(417, 83);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(47, 23);
            this.guna2HtmlLabel6.TabIndex = 7;
            this.guna2HtmlLabel6.Text = "10 PC";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.Silver;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(350, 83);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(61, 23);
            this.guna2HtmlLabel7.TabIndex = 6;
            this.guna2HtmlLabel7.Text = "Booker:";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(249, 83);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(47, 23);
            this.guna2HtmlLabel4.TabIndex = 5;
            this.guna2HtmlLabel4.Text = "16 PC";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Silver;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(168, 83);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(75, 23);
            this.guna2HtmlLabel5.TabIndex = 4;
            this.guna2HtmlLabel5.Text = "Avaliable:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(75, 83);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(47, 23);
            this.guna2HtmlLabel3.TabIndex = 3;
            this.guna2HtmlLabel3.Text = "50 PC";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Silver;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 83);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(57, 23);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Online:";
            // 
            // imgAdmin
            // 
            this.imgAdmin.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgAdmin.ErrorImage")));
            this.imgAdmin.Image = ((System.Drawing.Image)(resources.GetObject("imgAdmin.Image")));
            this.imgAdmin.Location = new System.Drawing.Point(222, 12);
            this.imgAdmin.Name = "imgAdmin";
            this.imgAdmin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgAdmin.ShadowDecoration.Parent = this.imgAdmin;
            this.imgAdmin.Size = new System.Drawing.Size(40, 40);
            this.imgAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAdmin.TabIndex = 1;
            this.imgAdmin.TabStop = false;
            // 
            // lbPermission
            // 
            this.lbPermission.BackColor = System.Drawing.Color.Transparent;
            this.lbPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPermission.ForeColor = System.Drawing.Color.White;
            this.lbPermission.Location = new System.Drawing.Point(12, 12);
            this.lbPermission.Name = "lbPermission";
            this.lbPermission.Size = new System.Drawing.Size(91, 35);
            this.lbPermission.TabIndex = 0;
            this.lbPermission.Text = "Admin";
            // 
            // pnCustomerView
            // 
            this.pnCustomerView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCustomerView.Location = new System.Drawing.Point(1129, 0);
            this.pnCustomerView.Name = "pnCustomerView";
            this.pnCustomerView.ShadowDecoration.Parent = this.pnCustomerView;
            this.pnCustomerView.Size = new System.Drawing.Size(421, 866);
            this.pnCustomerView.TabIndex = 1;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtAddcomputer
            // 
            this.txtAddcomputer.CheckedState.Parent = this.txtAddcomputer;
            this.txtAddcomputer.CustomImages.Parent = this.txtAddcomputer;
            this.txtAddcomputer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddcomputer.ForeColor = System.Drawing.Color.White;
            this.txtAddcomputer.HoverState.Parent = this.txtAddcomputer;
            this.txtAddcomputer.Location = new System.Drawing.Point(889, 664);
            this.txtAddcomputer.Name = "txtAddcomputer";
            this.txtAddcomputer.ShadowDecoration.Parent = this.txtAddcomputer;
            this.txtAddcomputer.Size = new System.Drawing.Size(180, 45);
            this.txtAddcomputer.TabIndex = 5;
            this.txtAddcomputer.Text = "Thêm máy";
            this.txtAddcomputer.Click += new System.EventHandler(this.txtAddcomputer_Click);
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1550, 866);
            this.Controls.Add(this.pnCustomerView);
            this.Controls.Add(this.pnDashBoardMaint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmDashBoard";
            this.pnDashBoardMaint.ResumeLayout(false);
            this.pnDashBoardManager.ResumeLayout(false);
            this.pnOverview.ResumeLayout(false);
            this.pnOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnDashBoardMaint;
        private Guna.UI2.WinForms.Guna2Panel pnCustomerView;
        private Guna.UI2.WinForms.Guna2Panel pnOverview;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2Panel pnDashBoardManager;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSort;
        private Guna.UI2.WinForms.Guna2ComboBox cbbFloors;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        public Guna.UI2.WinForms.Guna2CirclePictureBox imgAdmin;
        public Guna.UI2.WinForms.Guna2HtmlLabel lbPermission;
        public Guna.UI2.WinForms.Guna2HtmlLabel lbName;
        public System.Windows.Forms.FlowLayoutPanel flComputerList;
        private Guna.UI2.WinForms.Guna2Button txtAddcomputer;
    }
}