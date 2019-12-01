
using QLTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTraSua.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null)instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "SELECT f.NAME_DRINK, bi.QUANTITY, f.PRICE, f.PRICE*bi.QUANTITY AS totalPrice FROM dbo.DETAIL_BILL AS bi, dbo.BILL AS b, dbo.DRINK AS f, dbo.TABLE_DRINK AS d WHERE d.ID_TABLE= b.ID_TABLE AND bi.ID_BILL = b.ID_BILL AND bi.ID_DRINK = f.ID_DRINK AND b.IS_PAID=0 AND b.ID_TABLE = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}

