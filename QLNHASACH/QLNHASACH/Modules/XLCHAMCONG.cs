using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNHASACH.Modules
{
    class XLCHAMCONG: XLBANG
    {
        public XLCHAMCONG() : base("CHAMCONG") { }
        public XLCHAMCONG(string pQuery) : base("CHAMCONG", pQuery) { }
    }
}
