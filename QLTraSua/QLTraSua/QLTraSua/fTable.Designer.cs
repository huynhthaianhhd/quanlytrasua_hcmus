namespace QLTraSua
{
    partial class fTable
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Trà sữa Panda",
            "2",
            "54000"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Trà sữa Pudding",
            "2",
            "54000"}, -1);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.isTakeaway = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabDetailNV = new System.Windows.Forms.TabControl();
            this.ThongTinChung = new System.Windows.Forms.TabPage();
            this.nv_sdt = new System.Windows.Forms.Label();
            this.nv_email = new System.Windows.Forms.Label();
            this.nv_username = new System.Windows.Forms.Label();
            this.nv_hoten = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSdt = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.labelTTNV = new System.Windows.Forms.Label();
            this.MatKhau = new System.Windows.Forms.TabPage();
            this.saveNewPassword = new System.Windows.Forms.Button();
            this.tb_passwordNew_2 = new System.Windows.Forms.TextBox();
            this.tb_passwordNew = new System.Windows.Forms.TextBox();
            this.passwordNew_2 = new System.Windows.Forms.Label();
            this.passwordNew = new System.Windows.Forms.Label();
            this.tb_passwordCurrent = new System.Windows.Forms.TextBox();
            this.passwordCurrent = new System.Windows.Forms.Label();
            this.tabLogout = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.fTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabOrder.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabDetailNV.SuspendLayout();
            this.ThongTinChung.SuspendLayout();
            this.MatKhau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabOrder);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 2);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1050, 538);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.flpTable);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1042, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bàn";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpTable.Location = new System.Drawing.Point(0, 0);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(1042, 501);
            this.flpTable.TabIndex = 0;
            this.flpTable.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.panel7);
            this.tabOrder.Controls.Add(this.panel6);
            this.tabOrder.Controls.Add(this.flowLayoutPanel1);
            this.tabOrder.Location = new System.Drawing.Point(4, 28);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrder.Size = new System.Drawing.Size(1042, 506);
            this.tabOrder.TabIndex = 1;
            this.tabOrder.Text = "Chọn món";
            this.tabOrder.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button6);
            this.panel7.Controls.Add(this.button5);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(714, 389);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(328, 109);
            this.panel7.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(74)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(151, 61);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 41);
            this.button6.TabIndex = 3;
            this.button6.Text = "THANH TOÁN";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(74)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(3, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 41);
            this.button5.TabIndex = 2;
            this.button5.Text = "LƯU";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(93, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "108000đ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "TỔNG :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.isTakeaway);
            this.panel6.Controls.Add(this.listView1);
            this.panel6.Location = new System.Drawing.Point(711, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(331, 380);
            this.panel6.TabIndex = 0;
            // 
            // isTakeaway
            // 
            this.isTakeaway.AutoSize = true;
            this.isTakeaway.BackColor = System.Drawing.Color.Transparent;
            this.isTakeaway.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.isTakeaway.FlatAppearance.BorderSize = 2;
            this.isTakeaway.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.isTakeaway.Location = new System.Drawing.Point(7, 352);
            this.isTakeaway.Name = "isTakeaway";
            this.isTakeaway.Size = new System.Drawing.Size(83, 23);
            this.isTakeaway.TabIndex = 1;
            this.isTakeaway.Text = "Mang đi";
            this.isTakeaway.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            listViewItem1.Tag = "";
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(3, 1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(325, 345);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "1";
            this.columnHeader1.Text = "Trà Sữa";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "2";
            this.columnHeader2.Text = "SL";
            this.columnHeader2.Width = 58;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Tag = "3";
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 105;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(705, 506);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1042, 506);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hoá đơn";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tabDetailNV);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1042, 506);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tài khoản";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabDetailNV
            // 
            this.tabDetailNV.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabDetailNV.Controls.Add(this.ThongTinChung);
            this.tabDetailNV.Controls.Add(this.MatKhau);
            this.tabDetailNV.Controls.Add(this.tabLogout);
            this.tabDetailNV.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabDetailNV.ItemSize = new System.Drawing.Size(40, 100);
            this.tabDetailNV.Location = new System.Drawing.Point(0, 0);
            this.tabDetailNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDetailNV.Multiline = true;
            this.tabDetailNV.Name = "tabDetailNV";
            this.tabDetailNV.SelectedIndex = 0;
            this.tabDetailNV.Size = new System.Drawing.Size(1042, 506);
            this.tabDetailNV.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabDetailNV.TabIndex = 0;
            // 
            // ThongTinChung
            // 
            this.ThongTinChung.Controls.Add(this.nv_sdt);
            this.ThongTinChung.Controls.Add(this.nv_email);
            this.ThongTinChung.Controls.Add(this.nv_username);
            this.ThongTinChung.Controls.Add(this.nv_hoten);
            this.ThongTinChung.Controls.Add(this.labelEmail);
            this.ThongTinChung.Controls.Add(this.labelSdt);
            this.ThongTinChung.Controls.Add(this.labelUsername);
            this.ThongTinChung.Controls.Add(this.labelHoTen);
            this.ThongTinChung.Controls.Add(this.labelTTNV);
            this.ThongTinChung.Location = new System.Drawing.Point(104, 4);
            this.ThongTinChung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThongTinChung.Name = "ThongTinChung";
            this.ThongTinChung.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThongTinChung.Size = new System.Drawing.Size(934, 498);
            this.ThongTinChung.TabIndex = 0;
            this.ThongTinChung.Text = "Thông tin nhân viên";
            this.ThongTinChung.UseVisualStyleBackColor = true;
            // 
            // nv_sdt
            // 
            this.nv_sdt.AutoSize = true;
            this.nv_sdt.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nv_sdt.Location = new System.Drawing.Point(444, 220);
            this.nv_sdt.Name = "nv_sdt";
            this.nv_sdt.Size = new System.Drawing.Size(55, 22);
            this.nv_sdt.TabIndex = 0;
            this.nv_sdt.Text = "label6";
            // 
            // nv_email
            // 
            this.nv_email.AutoSize = true;
            this.nv_email.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nv_email.Location = new System.Drawing.Point(444, 258);
            this.nv_email.Name = "nv_email";
            this.nv_email.Size = new System.Drawing.Size(55, 22);
            this.nv_email.TabIndex = 0;
            this.nv_email.Text = "label6";
            // 
            // nv_username
            // 
            this.nv_username.AutoSize = true;
            this.nv_username.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nv_username.Location = new System.Drawing.Point(444, 182);
            this.nv_username.Name = "nv_username";
            this.nv_username.Size = new System.Drawing.Size(55, 22);
            this.nv_username.TabIndex = 0;
            this.nv_username.Text = "label6";
            // 
            // nv_hoten
            // 
            this.nv_hoten.AutoSize = true;
            this.nv_hoten.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nv_hoten.Location = new System.Drawing.Point(444, 148);
            this.nv_hoten.Name = "nv_hoten";
            this.nv_hoten.Size = new System.Drawing.Size(55, 22);
            this.nv_hoten.TabIndex = 0;
            this.nv_hoten.Text = "label6";
            this.nv_hoten.Click += new System.EventHandler(this.nv_hoten_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(206, 258);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(50, 22);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            // 
            // labelSdt
            // 
            this.labelSdt.AutoSize = true;
            this.labelSdt.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSdt.Location = new System.Drawing.Point(206, 220);
            this.labelSdt.Name = "labelSdt";
            this.labelSdt.Size = new System.Drawing.Size(104, 22);
            this.labelSdt.TabIndex = 0;
            this.labelSdt.Text = "Số điện thoại";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(206, 182);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(85, 22);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoTen.Location = new System.Drawing.Point(206, 148);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(80, 22);
            this.labelHoTen.TabIndex = 0;
            this.labelHoTen.Text = "Họ và Tên";
            // 
            // labelTTNV
            // 
            this.labelTTNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTTNV.AutoSize = true;
            this.labelTTNV.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTTNV.Location = new System.Drawing.Point(287, 54);
            this.labelTTNV.Name = "labelTTNV";
            this.labelTTNV.Size = new System.Drawing.Size(297, 41);
            this.labelTTNV.TabIndex = 0;
            this.labelTTNV.Text = "Thông tin nhân viên";
            this.labelTTNV.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // MatKhau
            // 
            this.MatKhau.Controls.Add(this.saveNewPassword);
            this.MatKhau.Controls.Add(this.tb_passwordNew_2);
            this.MatKhau.Controls.Add(this.tb_passwordNew);
            this.MatKhau.Controls.Add(this.passwordNew_2);
            this.MatKhau.Controls.Add(this.passwordNew);
            this.MatKhau.Controls.Add(this.tb_passwordCurrent);
            this.MatKhau.Controls.Add(this.passwordCurrent);
            this.MatKhau.Location = new System.Drawing.Point(104, 4);
            this.MatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MatKhau.Size = new System.Drawing.Size(934, 498);
            this.MatKhau.TabIndex = 0;
            this.MatKhau.Text = "Thay đổi mật khẩu";
            this.MatKhau.UseVisualStyleBackColor = true;
            // 
            // saveNewPassword
            // 
            this.saveNewPassword.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNewPassword.Location = new System.Drawing.Point(428, 321);
            this.saveNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.saveNewPassword.Name = "saveNewPassword";
            this.saveNewPassword.Size = new System.Drawing.Size(94, 36);
            this.saveNewPassword.TabIndex = 0;
            this.saveNewPassword.Text = "Lưu";
            this.saveNewPassword.UseVisualStyleBackColor = true;
            this.saveNewPassword.Click += new System.EventHandler(this.saveNewPassword_Click);
            // 
            // tb_passwordNew_2
            // 
            this.tb_passwordNew_2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passwordNew_2.Location = new System.Drawing.Point(447, 231);
            this.tb_passwordNew_2.Margin = new System.Windows.Forms.Padding(4);
            this.tb_passwordNew_2.Name = "tb_passwordNew_2";
            this.tb_passwordNew_2.Size = new System.Drawing.Size(280, 29);
            this.tb_passwordNew_2.TabIndex = 0;
            this.tb_passwordNew_2.UseSystemPasswordChar = true;
            // 
            // tb_passwordNew
            // 
            this.tb_passwordNew.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passwordNew.Location = new System.Drawing.Point(447, 186);
            this.tb_passwordNew.Margin = new System.Windows.Forms.Padding(4);
            this.tb_passwordNew.Name = "tb_passwordNew";
            this.tb_passwordNew.Size = new System.Drawing.Size(280, 29);
            this.tb_passwordNew.TabIndex = 0;
            this.tb_passwordNew.UseSystemPasswordChar = true;
            // 
            // passwordNew_2
            // 
            this.passwordNew_2.AutoSize = true;
            this.passwordNew_2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordNew_2.Location = new System.Drawing.Point(193, 238);
            this.passwordNew_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordNew_2.Name = "passwordNew_2";
            this.passwordNew_2.Size = new System.Drawing.Size(174, 22);
            this.passwordNew_2.TabIndex = 0;
            this.passwordNew_2.Text = "Nhập lại mật khẩu mới";
            // 
            // passwordNew
            // 
            this.passwordNew.AutoSize = true;
            this.passwordNew.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordNew.Location = new System.Drawing.Point(193, 193);
            this.passwordNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordNew.Name = "passwordNew";
            this.passwordNew.Size = new System.Drawing.Size(111, 22);
            this.passwordNew.TabIndex = 0;
            this.passwordNew.Text = "Mật khẩu mới";
            // 
            // tb_passwordCurrent
            // 
            this.tb_passwordCurrent.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passwordCurrent.Location = new System.Drawing.Point(447, 142);
            this.tb_passwordCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.tb_passwordCurrent.Name = "tb_passwordCurrent";
            this.tb_passwordCurrent.Size = new System.Drawing.Size(280, 29);
            this.tb_passwordCurrent.TabIndex = 0;
            this.tb_passwordCurrent.UseSystemPasswordChar = true;
            this.tb_passwordCurrent.TextChanged += new System.EventHandler(this.tb_passwordCurrent_TextChanged);
            // 
            // passwordCurrent
            // 
            this.passwordCurrent.AutoSize = true;
            this.passwordCurrent.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordCurrent.Location = new System.Drawing.Point(193, 149);
            this.passwordCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordCurrent.Name = "passwordCurrent";
            this.passwordCurrent.Size = new System.Drawing.Size(137, 22);
            this.passwordCurrent.TabIndex = 0;
            this.passwordCurrent.Text = "Mật khẩu hiện tại";
            this.passwordCurrent.Click += new System.EventHandler(this.label6_Click);
            // 
            // tabLogout
            // 
            this.tabLogout.Location = new System.Drawing.Point(104, 4);
            this.tabLogout.Margin = new System.Windows.Forms.Padding(4);
            this.tabLogout.Name = "tabLogout";
            this.tabLogout.Padding = new System.Windows.Forms.Padding(4);
            this.tabLogout.Size = new System.Drawing.Size(934, 498);
            this.tabLogout.TabIndex = 0;
            this.tabLogout.Text = "Đăng xuất";
            this.tabLogout.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1042, 506);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 28);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1042, 506);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // fTableBindingSource
            // 
            this.fTableBindingSource.DataSource = typeof(QLTraSua.fTable);
            // 
            // fTableBindingSource1
            // 
            this.fTableBindingSource1.DataSource = typeof(QLTraSua.fTable);
            // 
            // fTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 537);
            this.Controls.Add(this.tabControl);
            this.Name = "fTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabOrder.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabDetailNV.ResumeLayout(false);
            this.ThongTinChung.ResumeLayout(false);
            this.ThongTinChung.PerformLayout();
            this.MatKhau.ResumeLayout(false);
            this.MatKhau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fTableBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource fTableBindingSource;
        private System.Windows.Forms.BindingSource fTableBindingSource1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckBox isTakeaway;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabControl tabDetailNV;
        private System.Windows.Forms.TabPage ThongTinChung;
        private System.Windows.Forms.TabPage MatKhau;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.Label labelTTNV;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelSdt;
        private System.Windows.Forms.Label nv_sdt;
        private System.Windows.Forms.Label nv_email;
        private System.Windows.Forms.Label nv_username;
        private System.Windows.Forms.Label nv_hoten;
        private System.Windows.Forms.TabPage tabLogout;
        private System.Windows.Forms.TextBox tb_passwordCurrent;
        private System.Windows.Forms.Label passwordCurrent;
        private System.Windows.Forms.TextBox tb_passwordNew_2;
        private System.Windows.Forms.TextBox tb_passwordNew;
        private System.Windows.Forms.Label passwordNew_2;
        private System.Windows.Forms.Label passwordNew;
        private System.Windows.Forms.Button saveNewPassword;
        private System.Windows.Forms.TabPage tabPage4;
    }
}