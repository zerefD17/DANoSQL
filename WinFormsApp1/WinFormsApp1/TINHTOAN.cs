using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal static class TINHTOAN
    {
        public static decimal TinhTienDien(decimal consumption)
        {
            decimal price = 0;
            
            if (consumption <= 50)
            {
                price = consumption * 1.678m;
            }
            else if (consumption <= 100)
            {
                price = 50 * 1.678m + (consumption - 50) * 1.734m;
            }
            else if (consumption <= 200)
            {
                price = 50 * 1.678m + 50 * 1.734m + (consumption - 100) * 2.014m;
            }
            else if (consumption <= 300)
            {
                price = 50 * 1.678m + 50 * 1.734m + 100 * 2.014m + (consumption - 200) * 2.536m;
            }
            else if (consumption <= 400)
            {
                price = 50 * 1.678m + 50 * 1.734m + 100 * 2.014m + 100 * 2.536m + (consumption - 300) * 2.834m;
            }
            else
            {
                price = 50 * 1.678m + 50 * 1.734m + 100 * 2.014m + 100 * 2.536m + 100 * 2.834m + (consumption - 400) * 2.927m;
            }

            return price;

        }
        public static decimal TinhTienNuoc(decimal consumption)
        {
            decimal price = 0;

            if (consumption <= 10)
            {
                price = consumption * 5.973m;
            }
            else if (consumption <= 20)
            {
                price = 10 * 5.973m + (consumption - 10) * 7.052m;
            }
            else if (consumption <= 30)
            {
                price = 10 * 5.973m + 10 * 7.052m + (consumption - 20) * 8.669m;
            }
            else
            {
                price = 10 * 5.973m + 10 * 7.052m + 10 * 8.669m + (consumption - 30) * 15.929m;
            }

            return price;
        }

        public static decimal TONGTIEN(int csdien, int csnuoc)
        {
            decimal tong = TinhTienDien(csdien) + TinhTienNuoc(csnuoc);


            return tong;
        }
    }
}
