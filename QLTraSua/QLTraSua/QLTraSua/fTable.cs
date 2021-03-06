﻿using QLTraSua.DAO;
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
        BindingSource accountList = new BindingSource();
        BindingSource drinkList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        int isPaid = 0;
        bool firstRun = true;

        public fTable()
        {
            InitializeComponent();
            LoadAll();
        }

        void LoadAll()
        {
            LoadTable(-1);
            firstRun = false;
            tabDetailNV.DrawItem += new DrawItemEventHandler(tabDetailNV_DrawItem);
            tabAdminDetail.DrawItem += new DrawItemEventHandler(tabAdminDetail_DrawItem);
            tabIncome.DrawItem += new DrawItemEventHandler(tabIncome_DrawItem);
            tabDetailNV.SelectedIndexChanged += new EventHandler(Tabs_SelectedIndexChanged);
            loadNhanVien();
            loadUpdate();
            LoadAccount();
            AddAccountBinding();
            LoadTotalIncome();
            //Drink
            LoadDrink();
            LoadCategory();
            AddFoodBinding();
            AddCategoryBinding();
            LoadCategoryToBox(cbDrinkCategory);
        }

        public void LoadTotalIncome()
        {
            lbTongTien.Text = IncomeDAO.Instance.GetTotalIncome() + " đồng";
            lbSoLuongDon.Text = IncomeDAO.Instance.GetCountTotal() + " đơn";
            lbTakeAway.Text = IncomeDAO.Instance.GetTakeAwayIncome() + " đồng";
            lbTakeAwayCount.Text = IncomeDAO.Instance.GetCountTakeAway() + " đơn";
            lbTable.Text = IncomeDAO.Instance.GetNotTakeAwayIncome() + " đồng";
            lbTableCount.Text = IncomeDAO.Instance.GetCountNotTakeAway() + " đơn";
        }

        void LoadAccount()
        {
            dataListNV.DataSource = accountList;
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
            tbAdminPhone.Controls[0].Visible = false;
        }

        void AddAccountBinding()
        {
            tbAdminUsername.DataBindings.Add(new Binding("Text", dataListNV.DataSource, "USERNAME", true, DataSourceUpdateMode.Never));
            tbAdminName.DataBindings.Add(new Binding("Text", dataListNV.DataSource, "NAME_USER", true, DataSourceUpdateMode.Never));
            tbAdminPhone.DataBindings.Add(new Binding("Value", dataListNV.DataSource, "PHONE", true, DataSourceUpdateMode.Never));
            tbAdminEmail.DataBindings.Add(new Binding("Text", dataListNV.DataSource, "EMAIL", true, DataSourceUpdateMode.Never));
            cbPermission.DataBindings.Add(new Binding("Text", dataListNV.DataSource, "PERMISSION", true, DataSourceUpdateMode.Never));
        }

        //Drink & Category
        void LoadDrink()
        {
            dataListDrink.DataSource = drinkList;
            drinkList.DataSource = FoodDAO.Instance.GetListFood();
        }

        void LoadCategory()
        {
            dataListCategory.DataSource = categoryList;
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        }

        void AddFoodBinding()
        {
            tbIDDrink.DataBindings.Add(new Binding("Text", dataListDrink.DataSource, "ID", true, DataSourceUpdateMode.Never));
            tbNameDrink.DataBindings.Add(new Binding("Text", dataListDrink.DataSource, "Name", true, DataSourceUpdateMode.Never));
            nmPriceDrink.DataBindings.Add(new Binding("Value", dataListDrink.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        void AddCategoryBinding()
        {
            tbIDCategory.DataBindings.Add(new Binding("Text", dataListCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
            tbNameCategory.DataBindings.Add(new Binding("Text", dataListCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }

        void LoadCategoryToBox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        private void tbIDDrink_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataListDrink.SelectedCells.Count > 0)
                {
                    int id = (int)dataListDrink.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category category = CategoryDAO.Instance.GetCategoryByID(id);

                    cbDrinkCategory.SelectedItem = category;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbDrinkCategory.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbDrinkCategory.SelectedIndex = index;
                }
            }
            catch
            {

            }
        }

        public List<Food> SearchDrinkByName(string name)
        {
            List<Food> listDrink = FoodDAO.Instance.SearchDrinkByName(name);
            return listDrink;
        }

        //Drink OnClick
        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            string name = tbNameDrink.Text;
            int categoryID = (cbDrinkCategory.SelectedItem as Category).ID;
            float price = (float)nmPriceDrink.Value;

            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadDrink();
            }
            else
            {
                MessageBox.Show("Có lỗi rồi!");
            }
        }

        private void btnEditDrink_Click(object sender, EventArgs e)
        {
            string name = tbNameDrink.Text;
            int categoryID = (cbDrinkCategory.SelectedItem as Category).ID;
            float price = (float)nmPriceDrink.Value;
            int id = Convert.ToInt32(tbIDDrink.Text);

            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Đã cập nhật thông tin món");
                LoadDrink();
            }
            else
            {
                MessageBox.Show("Có lỗi rồi!");
            }
        }

        private void btnDeleteDrink_Click(object sender, EventArgs e)
        {
            string name = tbNameDrink.Text;
            int categoryID = (cbDrinkCategory.SelectedItem as Category).ID;
            float price = (float)nmPriceDrink.Value;
            int id = Convert.ToInt32(tbIDDrink.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Đã xóa món");
                LoadDrink();
            }
            else
            {
                MessageBox.Show("Có lỗi rồi!");
            }
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            drinkList.DataSource = SearchDrinkByName(tbSearchDrink.Text);
        }

        //Category OnClick

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = tbNameCategory.Text;

            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm danh mục thành công");
                LoadCategory();
            }
            else
            {
                MessageBox.Show("Có lỗi rồi!");
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string name = tbNameCategory.Text;
            int id = Convert.ToInt32(tbIDCategory.Text);

            if (CategoryDAO.Instance.UpdateCategory(id, name))
            {
                MessageBox.Show("Sửa thông tin danh mục thành công");
                LoadCategory();
            }
            else
            {
                MessageBox.Show("Có lỗi rồi!");
            }
        }

        

        //End Drink & Category

        void loadUpdate()
        {
            List<Table> listTABLE = TableDAO.Instance.LoadTableList(-1);
            listTABLE.RemoveAt(0);
            cbUp.DataSource = listTABLE;
            cbUp.DisplayMember = "Name";
        }
        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabDetailNV.SelectedIndex == 3)
            {
                this.Close();
            }
            else if (tabDetailNV.SelectedIndex == 2)
            {
                List<string> nvDetail = UserDAO.Instance.LoadNhanVienDetail();

                if (nvDetail[4] == "0")
                {
                    tabDetailNV.SelectTab(ThongTinChung);
                    MessageBox.Show("Bạn không phải là admin", "Thông báo");
                }
                else
                {

                }
            }
        }

        private void loadNhanVien()
        {
            List<string> nvDetail = UserDAO.Instance.LoadNhanVienDetail();
            nv_hoten.Text = nvDetail[0];
            nv_username.Text = nvDetail[1];
            nv_sdt.Text = nvDetail[2];
            nv_email.Text = nvDetail[3];
            nv_permission.Text = nvDetail[4];
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

        private void tabAdminDetail_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabAdminDetail.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabAdminDetail.GetTabRect(e.Index);

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

        private void tabIncome_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabIncome.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabIncome.GetTabRect(e.Index);

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
        public void LoadTable(int empty_table_id)
        {
            flpTable.Controls.Clear();

            List<Table> tableList = TableDAO.Instance.LoadTableList(empty_table_id);

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                string status;
                if (BillDAO.Instance.GetBillByTableID(item.ID) == 1)
                {
                    status = "Đã thanh toán";
                    isPaid = 1;
                }
                else
                    status = "Chưa thanh toán";
                if (empty_table_id != -1 || item.Status == "Trống")
                {
                    status = "Chưa thanh toán";
                }
                btn.Text = item.Name + Environment.NewLine + item.Status + Environment.NewLine + Environment.NewLine + status;
                btn.Click += btn_Click;
                btn.MouseHover += btn_MouseHover;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderColor = Color.Green;
                        btn.FlatAppearance.BorderSize = 1;
                        btn.ForeColor = Color.Green;
                        break;
                    default:
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderColor = Color.Red;
                        btn.FlatAppearance.BorderSize = 1;
                        btn.ForeColor = Color.Red;

                        break;
                }
                if (item.Status == "Đã có người" && status == "Đã thanh toán")
                {
                    btn.Enabled = false;
                }
                else
                {
                    btn.Enabled = true;
                }
                flpTable.Controls.Add(btn);
            }
        }

        void btn_MouseHover(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            ShowBill_2(tableID);
        }

        public void ShowBill_2(int id)
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
            f.ShowDialog();
            this.Show();
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void update_tableNull(object sender, EventArgs e)
        {

        }

        private void fTable_Load(object sender, EventArgs e)
        {

        }

        private void saveNewPassword_Click(object sender, EventArgs e)
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

        void AddAccount(string username, int permission, string name_user, string email, int phone)
        {
            if (AccountDAO.Instance.InsertAccount(username, permission, name_user, email, phone))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
            LoadAccount();
        }

        void EditAccount(string username, int permission, string name_user, string email, int phone)
        {
            if (AccountDAO.Instance.UpdateAccount(username, permission, name_user, email, phone))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }
            LoadAccount();
        }

        void DeleteAccount(string username)
        {
            if (global.GetSetUsername == username)
            {
                MessageBox.Show("Bạn đang đăng nhập bằng tài khoản này", "Error");
            }
            else
            {
                if (AccountDAO.Instance.DeleteAccount(username))
                {
                    MessageBox.Show("Xóa tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại");
                }
                LoadAccount();
            }
        }

        void ResetPassword(string username)
        {
            if (global.GetSetUsername == username)
            {
                if (MessageBox.Show("Bạn reset mật khẩu của chính mình?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (AccountDAO.Instance.ResetPassword(username))
                    {
                        MessageBox.Show("Reset mật khẩu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Reset mật khẩu thất bại");
                    }
                }
                else
                {
                }
            }
            else
            {
                if (AccountDAO.Instance.ResetPassword(username))
                {
                    MessageBox.Show("Reset mật khẩu thành công");
                }
                else
                {
                    MessageBox.Show("Reset mật khẩu thất bại");
                }
            }
        }

        private void buttonAdminSave_Click(object sender, EventArgs e)
        {
            string username = tbAdminUsername.Text;
            int permission = (cbPermission.Text == "0") ? 0 : 1;
            string name_user = tbAdminName.Text;
            string email = tbAdminEmail.Text;
            int phone = (int)tbAdminPhone.Value;

            EditAccount(username, permission, name_user, email, phone);
        }

        private void buttonAdminDelete_Click(object sender, EventArgs e)
        {
            string username = tbAdminUsername.Text;
            DeleteAccount(username);
        }

        private void buttonAdminAdd_Click(object sender, EventArgs e)
        {
            string username = tbAdminUsername.Text;
            int permission = (cbPermission.Text == "0") ? 0 : 1;
            string name_user = tbAdminName.Text;
            string email = tbAdminEmail.Text;
            int phone = (int)tbAdminPhone.Value;

            AddAccount(username, permission, name_user, email, phone);
        }

        private void buttonAdminReset_Click(object sender, EventArgs e)
        {
            string username = tbAdminUsername.Text;
            ResetPassword(username);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (cbUp.SelectedItem == null)
            {
                return;
            }
            Table selected = cbUp.SelectedItem as Table;
            id = selected.ID;
            int isPaid = BillDAO.Instance.GetBillByTableID(id);
            if (isPaid == 0 && selected.Status =="Đã có người")
            {
                MessageBox.Show("Không thể cập nhật vì chưa thanh toán");
            }
            else
            {
                if (TableDAO.Instance.updateEmptyTable(id))
                {
                    MessageBox.Show("Cập nhật bàn trống thành công");
                    LoadTable(id);
                }
                else
                {
                    MessageBox.Show("Cập nhật bàn trống thất bại");
                }
            }
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tabGeneral_SelectedIndexChange(object sender, EventArgs e)
        {
            if (tabGeneral.SelectedIndex == 4)
            {
                List<string> nvDetail = UserDAO.Instance.LoadNhanVienDetail();

                if (nvDetail[4] == "0")
                {
                    tabGeneral.SelectTab(tabBan);
                    MessageBox.Show("Bạn không phải là admin", "Thông báo");
                }
            }
        }
        void LoadListByDate(DateTime dateFrom, DateTime dateTo)
        {
            dtgBill.DataSource = BillDAO.Instance.GetListByDate(dateFrom, dateTo);
        }
        private void btnTk_Click(object sender, EventArgs e)
        {
            LoadListByDate(dtpFrom.Value, dtpToday.Value);
        }

        
    }

}
