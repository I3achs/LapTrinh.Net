using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thucHanh5_11
{
    internal class Service
    {
        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public decimal GiaDV { get; set; }

        public Service(string madv, string tendv, decimal giadv)
        {
            MaDV = madv;
            TenDV = tendv;
            GiaDV = giadv;
        }
    }
}
