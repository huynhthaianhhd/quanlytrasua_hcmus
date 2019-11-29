
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTraSua.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckin, int status)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckin;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["ID_BILL"];
            this.DateCheckIn = (DateTime?)row["ORDERTIME"];

            this.Status = (int)row["IS_PAID"];

        }

        

        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }


        private DateTime? dateCheckIn;

        public DateTime? DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}

