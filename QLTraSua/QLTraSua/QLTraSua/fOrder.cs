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
        public fOrder()
        {
            InitializeComponent();
            ShowBill(global.TableID);
            LoadCategory();
            LoadFood();
        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
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
            imgList = new ImageList() { ImageSize = new Size(50, 50) };
            lsvOrder.LargeImageList = imgList;
            foreach (Food item in listFood) 
            {
                ListViewItem lsvItem = new ListViewItem(item.Name.ToString());
                imgList.Images.Add(Image.FromFile("D:/1/"+item.ID +".jpg"));
                lsvItem.ImageIndex = item.ID-1;
                lsvOrder.Items.Add(lsvItem);
            }
        }
        void LoadFoodListByCategoryID(int id)
        {
            lsvOrder.Items.Clear();
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            ImageList imgList ;
            
            imgList = new ImageList() { ImageSize = new Size(50, 50) };
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
            foreach (QLTraSua.DTO.Menu item in listBillInfor)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                lsvBill.Items.Add(lsvItem);
            }
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
            LoadFoodListByCategoryID(id);
        }
    }
}
