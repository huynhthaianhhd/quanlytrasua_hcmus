
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

            string query = "SELECT * FROM DRINK WHERE ID_TYPE = " + id;

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

            string query = "SELECT * FROM DRINK";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

       
    }
}

