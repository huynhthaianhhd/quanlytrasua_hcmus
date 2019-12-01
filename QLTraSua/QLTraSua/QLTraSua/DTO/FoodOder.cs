
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTraSua.DTO
{
    public class FoodOrder
    {
        public FoodOrder(int id,int count)
        {
            this.FoodID = id;
            this.FoodCount = count;
        }


        private int foodCount;

        public int FoodCount
        {
            get { return foodCount; }
            set { foodCount = value; }
        }
        private int foodID;


        public int FoodID
        {
            get { return foodID; }
            set { foodID = value; }
        }

        

        
    }
}

