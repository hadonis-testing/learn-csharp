using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS04
{
    class TinhCan
    {
        public void Sub(UserInput u) => u.sukienNhapso += Can;

        public void Can(object sender, EventArgs e)
        {
            DuLieuNhap dulieu = (DuLieuNhap)e;

            Console.WriteLine($"Can bac 2 cua {dulieu.data} la {Math.Sqrt(dulieu.data)}");
        }
    }
}
