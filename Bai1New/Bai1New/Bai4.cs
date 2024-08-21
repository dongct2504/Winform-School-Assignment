using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1New
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNum.Text))
            {
                return;
            }

            int txtNumValue = Convert.ToInt32(txtNum.Text);
        }

        //private static string ConvertNumberToVietnameseWords(int number)
        //{
        //    if (number == 0)
        //    {
        //        return "Không";
        //    }

        //    string result = "";
        //    int hundred = number / 100;
        //    int ten = (number % 100) / 10;
        //    int unit = number % 10;

        //    if (hundred > 0)
        //    {
        //        switch (hundred)
        //        {
        //            case 1: result += "một trăm "; break;
        //            case 2: result += "hai trăm "; break;
        //            case 3: result += "ba trăm "; break;
        //            case 4: result += "bốn trăm "; break;
        //            case 5: result += "năm trăm "; break;
        //            case 6: result += "sáu trăm "; break;
        //            case 7: result += "bảy trăm "; break;
        //            case 8: result += "tám trăm "; break;
        //            case 9: result += "chín trăm "; break;
        //        }
        //        if (ten == 0 && unit != 0)
        //            result += "linh ";
        //    }
        //}
    }
}
