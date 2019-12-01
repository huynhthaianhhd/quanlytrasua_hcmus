using QLTraSua.DAO;
using QLTraSua.DTO;
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

namespace QLTraSua
{
    public partial class fOrder : Form
    {
        List<FoodOrder> listFoodOrder = new List<FoodOrder>();
        fTable ftable;
        public fOrder()
        {
          
            InitializeComponent();
            int tableID = global.TableID;
            string name;
            if (tableID != 0) name = "Bàn " + tableID;
            else name = "Mang đi";
            ShowBill(tableID);
            LoadCategory();
            LoadFood();
            nameOrder.Text = name;
        }
        public fOrder(fTable fTable)
        {
            this.ftable = fTable;
        }
        
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            Category category = new Category(-1,"Tất cả");
            listCategory.Insert(0,category);
            cbType.DataSource = listCategory;
            cbType.DisplayMember = "Name";
        }
        void LoadImageList()
        {

        }
        void LoadFood()
        {
            
            lsvOrder.Items.Clear();
            List<Food> listFood = FoodDAO.Instance.GetListFood();
            ImageList imgList;
            imgList = new ImageList() { ImageSize = new Size(60, 60) };
            lsvOrder.LargeImageList = imgList;
            foreach (Food item in listFood) 
            {
                ListViewItem lsvItem = new ListViewItem(item.Name.ToString());
                imgList.Images.Add(Image.FromFile(Application.StartupPath + "\\Image\\" + item.ID + ".jpg"));
             //   imgList.Images.Add(Image.FromFile("D:/1/"+item.ID +".jpg"));
                lsvItem.ImageIndex = item.ID-1;
                lsvOrder.Items.Add(lsvItem);
            }
        }
        void LoadFoodListByCategoryID(int id)
        {
            lsvOrder.Items.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            ImageList imgList ;
            
            imgList = new ImageList() { ImageSize = new Size(60,60) };
            lsvOrder.LargeImageList = imgList;
            imgList.Images.Clear();
            int i = 0;
            foreach (Food item in listFood)
            {
                ListViewItem lsvItem = new ListViewItem(item.Name.ToString());
                imgList.Images.Add(Image.FromFile("D:/1/"+ item.ID + ".jpg"));
                lsvItem.ImageIndex = i;
                i++;
                lsvOrder.Items.Add(lsvItem);
            }

            
        }


        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<QLTraSua.DTO.Menu> listBillInfor = MenuDAO.Instance.GetListMenuByTable(id);
            float grandTotalPrice = 0;
            foreach (QLTraSua.DTO.Menu item in listBillInfor)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                grandTotalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            grandPrice.Text = grandTotalPrice.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            if (id==-1)
            {
                LoadFood();
            }
            else
                LoadFoodListByCategoryID(id);
        }

        private void listOrderItemClick(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;
            int check_exist = 0 ;
            int index = 0;
            if (lsv.SelectedItems.Count>0)
            {
                ListViewItem item = lsv.SelectedItems[0];

                fPopupOrder f = new fPopupOrder();
                f.PassName(item.Text.ToString());
                f.ShowDialog();
                this.Show();


                Food temp = FoodDAO.Instance.GetFoodByName(item.Text);

                for (int i = 0; i < lsvBill.Items.Count; i++)
                {
                    string name = lsvBill.Items[i].SubItems[0].Text;
                    if (item.Text == name)
                    {
                        check_exist = 1;
                        index = i; 
                    }
                }
                if (check_exist == 1)
                {
                    FoodOrder foodOrder = new FoodOrder(temp.ID, global.CountDrink);
                    listFoodOrder.Add(foodOrder);
                    grandPrice.Text = (Convert.ToInt32(grandPrice.Text) + global.CountDrink * temp.Price).ToString();
                    global.CountDrink = Convert.ToInt32(lsvBill.Items[index].SubItems[1].Text) + global.CountDrink;
                    lsvBill.Items[index].SubItems[1].Text = global.CountDrink.ToString();
                    lsvBill.Items[index].SubItems[3].Text = (global.CountDrink * temp.Price).ToString();
                    lsvBill.Update();

                    
                }
                else if (global.CountDrink > 0)
                {
                    ListViewItem lsvItem2 = new ListViewItem(temp.Name.ToString());
                    lsvItem2.SubItems.Add(global.CountDrink.ToString());
                    lsvItem2.SubItems.Add(temp.Price.ToString());
                    lsvItem2.SubItems.Add((global.CountDrink * temp.Price).ToString());
                    lsvBill.Items.Add(lsvItem2);
                    FoodOrder foodOrder = new FoodOrder(temp.ID, global.CountDrink);
                    listFoodOrder.Add(foodOrder);
                    lsvBill.Update();
                    grandPrice.Text = (Convert.ToInt32(grandPrice.Text) + global.CountDrink * temp.Price).ToString();
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            int tableID = global.TableID;
            int isTakeAway = 0;
            if (tableID != 0)
            {
                isTakeAway = 0;
            }
            else
                isTakeAway = 1;
            for (int i = 0; i < listFoodOrder.Count; i++)
            {
                int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(tableID);
                if (idBill == -1)
                {
                    BillDAO.Instance.InsertBill(tableID,0);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), listFoodOrder[i].FoodID, listFoodOrder[i].FoodCount);

                }
                else
                {
                    BillInfoDAO.Instance.InsertBillInfo(idBill, listFoodOrder[i].FoodID, listFoodOrder[i].FoodCount);
                }
            }
            ShowBill(tableID);
            if (System.Windows.Forms.Application.OpenForms["fTable"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["fTable"] as fTable).LoadTable(-1);
                (System.Windows.Forms.Application.OpenForms["fTable"] as fTable).ShowBill_2(tableID);
            }
            this.Close();
                
        }

        private void btn_checkOut_click(object sender, EventArgs e)
        {
            int tableID = global.TableID;

            //
            int isTakeAway = 0;
            if (tableID != 0)
            {
                isTakeAway = 0;
            }
            else
                isTakeAway = 1;
            for (int i = 0; i < listFoodOrder.Count; i++)
            {
                int idBill1 = BillDAO.Instance.GetUncheckBillIDByTableID(tableID);
                if (idBill1 == -1)
                {
                    BillDAO.Instance.InsertBill(tableID, isTakeAway);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), listFoodOrder[i].FoodID, listFoodOrder[i].FoodCount);

                }
                else
                {
                    BillInfoDAO.Instance.InsertBillInfo(idBill1, listFoodOrder[i].FoodID, listFoodOrder[i].FoodCount);
                }
            }
            //
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(tableID);

            double totalPrice = Convert.ToDouble(grandPrice.Text);

            if (idBill != -1)
            {
                string name;
                if (tableID != 0) name = "Bàn "+ tableID;
                else name = "Mang đi";
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\nTổng tiền = {1}", name, totalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.checkOut(idBill, (float)totalPrice);

                    if (System.Windows.Forms.Application.OpenForms["fTable"] != null)
                    {
                        (System.Windows.Forms.Application.OpenForms["fTable"] as fTable).LoadTable(-1);
                    }
                    this.Close();
                }
            }
        }
        
       
    }
}
