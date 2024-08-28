using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Buoi11.DTO
{
    public class PhongBan
    {
        private string MaPB;
        private string TenPB;
        

        public string maPB
        {
            get
            {
                return MaPB;
            }

            set
            {
                MaPB = value;
            }

        }

        public string tenPB
        {
            get
            {
                return TenPB;
            }

            set
            {
                TenPB = value;
            }

        }

        public PhongBan()
        {
        }

        public PhongBan(String MaPB, String TenPB)
        {
            this.MaPB = MaPB;
            this.TenPB = TenPB;
        }


    }
}
