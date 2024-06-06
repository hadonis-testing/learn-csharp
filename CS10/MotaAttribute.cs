using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS10
{
    [AttributeUsage(AttributeTargets.All)]
    public class MotaAttribute : Attribute
    {
        public string ThongTinChiTiet { get; set; }

        public MotaAttribute(string _ThongTinChiTiet)
        {
            ThongTinChiTiet = _ThongTinChiTiet;
        }
    }
}
