using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeeStore
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int discount = 0)
        {
            this.ID = id;   
            this.DateCheckIn = dateCheckIn;
            this.dateCheckOut = dateCheckOut;
            //this.Status = status;
            this.Discount = discount;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["MaHD"];
            this.DateCheckIn = (DateTime?)row["NgayDat"];
            var dateCheckOutTemp = row["NgayGiao"];
            if (dateCheckOutTemp.ToString() != "")
            {
                this.dateCheckOut = (DateTime?)row["NgayGiao"];
            }
            //this.Status = (int)row["TrangThai"];

            if (row["GiamGia"].ToString() != "")
                this.Discount = (int)row["GiamGia"];
        }

        private int discount;

        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }

       /* private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }*/

        private DateTime? dateCheckOut;

        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
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
