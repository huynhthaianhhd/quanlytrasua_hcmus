using QLTraSua.DAO;
using QLTraSua.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTraSua
{
    public partial class fTable : Form
    {
        public fTable()
        {
            InitializeComponent();
            LoadTable();
            tabDetailNV.DrawItem += new DrawItemEventHandler(tabDetailNV_DrawItem);
            tabDetailNV.SelectedIndexChanged += new EventHandler(Tabs_SelectedIndexChanged);
            loadNhanVien();
        }
        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabDetailNV.SelectedIndex == 2)
            {
                this.Close();
            }
        }

        private void loadNhanVien()
        {
            List<string> nvDetail = UserDAO.Instance.LoadNhanVienDetail();
            nv_hoten.Text = nvDetail[0];
            nv_username.Text = nvDetail[1];
            nv_sdt.Text = nvDetail[2];
            nv_email.Text = nvDetail[3];
        }
        private void tabDetailNV_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabDetailNV.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabDetailNV.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.PaleGreen);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 10.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }


        private bool changePassword(string currentPassword, string newPassword, string newPassword_2)
        {
            return UserDAO.Instance.ChangePassword(currentPassword, newPassword, newPassword_2);
        }
        void LoadTable()
        {
            flpTable.Controls.Clear();

            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            listView1.Items.Clear();
            List<QLTraSua.DTO.Menu> listBillInfor = MenuDAO.Instance.GetListMenuByTable(id);
            float grandTotalPrice = 0;
            foreach (QLTraSua.DTO.Menu item in listBillInfor)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                grandTotalPrice += item.TotalPrice;
                listView1.Items.Add(lsvItem);
            }
            grandTotal.Text = grandTotalPrice.ToString();
        }

        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            global.TableID = tableID;
            fOrder f = new fOrder();
            this.Hide();
            f.ShowDialog();
            this.Show();
            //ShowBill(tableID);
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hOÁĐƠNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void saveNewPassword_Click_1(object sender, EventArgs e)
        {
            string currentPassword = tb_passwordCurrent.Text;
            string newPassword = tb_passwordNew.Text;
            string newPassword_2 = tb_passwordNew_2.Text;

            if (changePassword(currentPassword, newPassword, newPassword_2))
            {
                MessageBox.Show("Thay đổi mật khẩu thành công", "Thành công");
            }
            else
            {
                MessageBox.Show("Thay đổi mật khẩu thất bại", "Thất bại");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
