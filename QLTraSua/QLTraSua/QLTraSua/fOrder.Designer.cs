namespace QLTraSua
{
    partial class fOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsvOrder = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nameOrder = new System.Windows.Forms.Label();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.saveOrder = new System.Windows.Forms.Button();
            this.grandPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvOrder);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 592);
            this.panel1.TabIndex = 0;
            // 
            // lsvOrder
            // 
            this.lsvOrder.Location = new System.Drawing.Point(14, 3);
            this.lsvOrder.Name = "lsvOrder";
            this.lsvOrder.Size = new System.Drawing.Size(560, 556);
            this.lsvOrder.TabIndex = 0;
            this.lsvOrder.UseCompatibleStateImageBehavior = false;
            this.lsvOrder.SelectedIndexChanged += new System.EventHandler(this.listOrderItemClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nameOrder);
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(592, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 510);
            this.panel2.TabIndex = 1;
            // 
            // nameOrder
            // 
            this.nameOrder.AutoSize = true;
            this.nameOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOrder.ForeColor = System.Drawing.Color.Red;
            this.nameOrder.Location = new System.Drawing.Point(3, 468);
            this.nameOrder.Name = "nameOrder";
            this.nameOrder.Size = new System.Drawing.Size(82, 24);
            this.nameOrder.TabIndex = 1;
            this.nameOrder.Text = "Mang đi";
            this.nameOrder.Click += new System.EventHandler(this.nameOrder_Click);
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.Location = new System.Drawing.Point(3, 3);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(315, 448);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 94;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SL";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 96;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.saveOrder);
            this.panel3.Controls.Add(this.grandPrice);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(592, 517);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 112);
            this.panel3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.ForeColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(171, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "THANH TOÁN";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_checkOut_click);
            // 
            // saveOrder
            // 
            this.saveOrder.BackColor = System.Drawing.Color.LimeGreen;
            this.saveOrder.ForeColor = System.Drawing.Color.Cornsilk;
            this.saveOrder.Location = new System.Drawing.Point(23, 48);
            this.saveOrder.Name = "saveOrder";
            this.saveOrder.Size = new System.Drawing.Size(111, 43);
            this.saveOrder.TabIndex = 2;
            this.saveOrder.Text = "LƯU";
            this.saveOrder.UseVisualStyleBackColor = false;
            this.saveOrder.Click += new System.EventHandler(this.save_Click);
            // 
            // grandPrice
            // 
            this.grandPrice.AutoSize = true;
            this.grandPrice.Location = new System.Drawing.Point(70, 9);
            this.grandPrice.Name = "grandPrice";
            this.grandPrice.Size = new System.Drawing.Size(64, 17);
            this.grandPrice.TabIndex = 1;
            this.grandPrice.Text = "108000đ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TỔNG : ";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(386, 4);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(200, 24);
            this.cbType.TabIndex = 3;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // fOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 631);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fOrder";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button saveOrder;
        private System.Windows.Forms.Label grandPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lsvOrder;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label nameOrder;
    }
}