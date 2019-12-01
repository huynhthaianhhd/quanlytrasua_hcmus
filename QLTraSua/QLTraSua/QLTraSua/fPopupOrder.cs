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
    public partial class fPopupOrder : Form
    {
        int count = 0;
        string name;
        public fPopupOrder()
        {
            InitializeComponent();
            

        }
        public void PassName(string a)
        {
            name = a.ToString();
            nameTS.Text = name.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            countDrink.Text = count.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            count--;
            if (count < 0)
                count = 0;
            countDrink.Text = count.ToString();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (count == 0)
                global.CountDrink = 0;
            else
                global.CountDrink = count;
            this.Close();
        }

        private void popUpclosing(object sender, FormClosingEventArgs e)
        {
            if (count == 0)
                global.CountDrink = 0;
        }
    }
}
