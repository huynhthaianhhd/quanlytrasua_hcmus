
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTraSua.DTO;

namespace QLTraSua.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        public static int TableWidth = 100;
        public static int TableHeight = 100;

        private TableDAO() { }


        public List<Table> LoadTableList(int empty_table_id)
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("US_getTableList");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                if (table.ID == empty_table_id)
                {
                    table.Status = "Trống";
                }
                tableList.Add(table);
            }

            return tableList;
        }
        public bool updateEmptyTable(int id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.TABLE_DRINK SET STATUS = N'Trống' WHERE ID_TABLE = " + id);
            return result > 0;
        }
    }
}

