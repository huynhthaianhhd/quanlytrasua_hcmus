using QLTraSua.DAO;
using QLTraSua.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<BillInfo> listBillInfor = BillInfoDAO.Instance.GetListBillInfo(BillDAO.Instance.GetUncheckBillIDByTableID(id));
            foreach (BillInfo item in listBillInfor)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodID.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvBill.Items.Add(lsvItem);
            }
        }
    }
}
