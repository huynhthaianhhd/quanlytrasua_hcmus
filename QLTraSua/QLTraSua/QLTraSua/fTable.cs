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
            loadTable();
        }

    
        #region Method
        
        void loadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button(){Width = TableDAO.TableWidth,Height=TableDAO.TableHeight};
                btn.Text = item.Name + Environment.NewLine + item.Status;
                switch (item.Status)
                {
                    case "Trống":
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderColor = Color.Green;
                        btn.FlatAppearance.BorderSize = 1;
                        btn.ForeColor = Color.Green;
                        break;
                    case "Đã có người":
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderColor = Color.Red;
                        btn.FlatAppearance.BorderSize = 1;
                        btn.ForeColor = Color.Red;
                        break;
                }
                flpTable.Controls.Add(btn);
            }

        }
        #endregion

        #region Events
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
