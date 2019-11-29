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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabDetailNV = new System.Windows.Forms.TabControl();
            this.ThongTinChung = new System.Windows.Forms.TabPage();
            this.nv_email = new System.Windows.Forms.Label();
            this.nv_sdt = new System.Windows.Forms.Label();
            this.nv_username = new System.Windows.Forms.Label();
            this.nv_hoten = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.saveNewPassword = new System.Windows.Forms.Button();
            this.tb_passwordNew_2 = new System.Windows.Forms.TextBox();
            this.tb_passwordNew = new System.Windows.Forms.TextBox();
            this.tb_passwordCurrent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.fTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabDetailNV.SuspendLayout();
            this.ThongTinChung.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fTableBindingSource1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(22, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1002, 506);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.flpTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(994, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bàn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(6, 3);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(553, 474);
            this.flpTable.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(994, 477);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hoá đơn";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tabDetailNV);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(994, 477);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tài khoản";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // tabDetailNV
            // 
            this.tabDetailNV.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabDetailNV.Controls.Add(this.ThongTinChung);
            this.tabDetailNV.Controls.Add(this.tabPage6);
            this.tabDetailNV.Controls.Add(this.tabPage5);
            this.tabDetailNV.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabDetailNV.ItemSize = new System.Drawing.Size(40, 100);
            this.tabDetailNV.Location = new System.Drawing.Point(89, 32);
            this.tabDetailNV.Multiline = true;
            this.tabDetailNV.Name = "tabDetailNV";
            this.tabDetailNV.SelectedIndex = 0;
            this.tabDetailNV.Size = new System.Drawing.Size(826, 415);
            this.tabDetailNV.TabIndex = 0;
            // 
            // ThongTinChung
            // 
            this.ThongTinChung.Controls.Add(this.nv_email);
            this.ThongTinChung.Controls.Add(this.nv_sdt);
            this.ThongTinChung.Controls.Add(this.nv_username);
            this.ThongTinChung.Controls.Add(this.nv_hoten);
            this.ThongTinChung.Controls.Add(this.label5);
            this.ThongTinChung.Controls.Add(this.label4);
            this.ThongTinChung.Controls.Add(this.label3);
            this.ThongTinChung.Controls.Add(this.label2);
            this.ThongTinChung.Controls.Add(this.label1);
            this.ThongTinChung.Location = new System.Drawing.Point(104, 4);
            this.ThongTinChung.Name = "ThongTinChung";
            this.ThongTinChung.Padding = new System.Windows.Forms.Padding(3);
            this.ThongTinChung.Size = new System.Drawing.Size(718, 407);
            this.ThongTinChung.TabIndex = 0;
            this.ThongTinChung.Text = "Thông tin nhân viên";
            this.ThongTinChung.UseVisualStyleBackColor = true;
            this.ThongTinChung.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // nv_email
            // 
            this.nv_email.AutoSize = true;
            this.nv_email.Location = new System.Drawing.Point(229, 226);
            this.nv_email.Name = "nv_email";
            this.nv_email.Size = new System.Drawing.Size(134, 17);
            this.nv_email.TabIndex = 8;
            this.nv_email.Text = "Thông tin nhân viên";
            // 
            // nv_sdt
            // 
            this.nv_sdt.AutoSize = true;
            this.nv_sdt.Location = new System.Drawing.Point(229, 184);
            this.nv_sdt.Name = "nv_sdt";
            this.nv_sdt.Size = new System.Drawing.Size(134, 17);
            this.nv_sdt.TabIndex = 7;
            this.nv_sdt.Text = "Thông tin nhân viên";
            // 
            // nv_username
            // 
            this.nv_username.AutoSize = true;
            this.nv_username.Location = new System.Drawing.Point(229, 138);
            this.nv_username.Name = "nv_username";
            this.nv_username.Size = new System.Drawing.Size(134, 17);
            this.nv_username.TabIndex = 6;
            this.nv_username.Text = "Thông tin nhân viên";
            // 
            // nv_hoten
            // 
            this.nv_hoten.AutoSize = true;
            this.nv_hoten.Location = new System.Drawing.Point(229, 95);
            this.nv_hoten.Name = "nv_hoten";
            this.nv_hoten.Size = new System.Drawing.Size(134, 17);
            this.nv_hoten.TabIndex = 5;
            this.nv_hoten.Text = "Thông tin nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên :";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin nhân viên";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.saveNewPassword);
            this.tabPage6.Controls.Add(this.tb_passwordNew_2);
            this.tabPage6.Controls.Add(this.tb_passwordNew);
            this.tabPage6.Controls.Add(this.tb_passwordCurrent);
            this.tabPage6.Controls.Add(this.label8);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Location = new System.Drawing.Point(104, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(718, 407);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // saveNewPassword
            // 
            this.saveNewPassword.Location = new System.Drawing.Point(272, 193);
            this.saveNewPassword.Name = "saveNewPassword";
            this.saveNewPassword.Size = new System.Drawing.Size(75, 23);
            this.saveNewPassword.TabIndex = 6;
            this.saveNewPassword.Text = "Lưu";
            this.saveNewPassword.UseVisualStyleBackColor = true;
            this.saveNewPassword.Click += new System.EventHandler(this.saveNewPassword_Click_1);
            // 
            // tb_passwordNew_2
            // 
            this.tb_passwordNew_2.Location = new System.Drawing.Point(290, 123);
            this.tb_passwordNew_2.Name = "tb_passwordNew_2";
            this.tb_passwordNew_2.Size = new System.Drawing.Size(100, 22);
            this.tb_passwordNew_2.TabIndex = 5;
            // 
            // tb_passwordNew
            // 
            this.tb_passwordNew.Location = new System.Drawing.Point(290, 68);
            this.tb_passwordNew.Name = "tb_passwordNew";
            this.tb_passwordNew.Size = new System.Drawing.Size(100, 22);
            this.tb_passwordNew.TabIndex = 4;
            // 
            // tb_passwordCurrent
            // 
            this.tb_passwordCurrent.Location = new System.Drawing.Point(290, 40);
            this.tb_passwordCurrent.Name = "tb_passwordCurrent";
            this.tb_passwordCurrent.Size = new System.Drawing.Size(100, 22);
            this.tb_passwordCurrent.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nhập lại mật khẩu mới";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mật khẩu mới";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mật khẩu hiện tại";
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(104, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(718, 407);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // fTableBindingSource
            // 
            this.fTableBindingSource.DataSource = typeof(QLTraSua.fTable);
            // 
            // fTableBindingSource1
            // 
            this.fTableBindingSource1.DataSource = typeof(QLTraSua.fTable);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.listView1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(565, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(404, 465);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(380, 462);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // fTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 540);
            this.Controls.Add(this.tabControl1);
            this.Name = "fTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabDetailNV.ResumeLayout(false);
            this.ThongTinChung.ResumeLayout(false);
            this.ThongTinChung.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fTableBindingSource1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource fTableBindingSource;
        private System.Windows.Forms.BindingSource fTableBindingSource1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabDetailNV;
        private System.Windows.Forms.TabPage ThongTinChung;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nv_email;
        private System.Windows.Forms.Label nv_sdt;
        private System.Windows.Forms.Label nv_username;
        private System.Windows.Forms.Label nv_hoten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveNewPassword;
        private System.Windows.Forms.TextBox tb_passwordNew_2;
        private System.Windows.Forms.TextBox tb_passwordNew;
        private System.Windows.Forms.TextBox tb_passwordCurrent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListView listView1;

    }
}