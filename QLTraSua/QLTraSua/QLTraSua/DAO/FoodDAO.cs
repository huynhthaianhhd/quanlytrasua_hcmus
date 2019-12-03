
using QLTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLTraSua.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null)instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO() { }

        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();

            string query = "SELECT * FROM dbo.DRINK WHERE ID_TYPE = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();

            string query = "SELECT * FROM dbo.DRINK WHERE ISDELETE = 0";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public Food GetFoodByName(string name)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.DRINK WHERE NAME_DRINK = N'"+ name +"'");

            if (data.Rows.Count > 0)
            {
                Food food = new Food(data.Rows[0]);
                return food;
            }
            return null;
        }

        public List<Food> SearchDrinkByName(string name)
        {
            List<Food> listDrink = new List<Food>();
            string query = string.Format("SELECT * FROM dbo.DRINK WHERE ISDELETE = 0 AND NAME_DRINK LIKE N'%{0}%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                listDrink.Add(food);
            }
            return listDrink;
        }


        public bool InsertFood(string name, int id, float price)
        {
            string query = string.Format("INSERT dbo.DRINK (NAME_DRINK, ID_TYPE, PRICE, ISDELETE) VALUES (N'{0}',{1}, {2}, {3})", name, id, price, 0);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return (result > 0);
        }

        public bool DeleteFood(string id)
        {
            string query = string.Format("UPDATE dbo.DRINK SET ISDELETE = 1 WHERE ID_DRINK = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateFood(int idDrink, string name, int id, float price)
        {
            string query = string.Format("UPDATE dbo.DRINK SET NAME_DRINK = N'{0}', ID_TYPE = {1}, PRICE = {2} WHERE ID_DRINK = {3}", name, id, price, idDrink);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return (result > 0);
        }

        public bool DeleteFood(int idDrink)
        {
            string query = string.Format("UPDATE dbo.DRINK SET ISDELETE = {0} WHERE ID_DRINK = {1}", 1, idDrink);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return (result > 0);
        }
    }
}

