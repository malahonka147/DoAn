using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace Lab4.Modules
{
    class XLLOAISP:XLBANG
    {

        public XLLOAISP() : base("LOAISP") { }
        public XLLOAISP(string pQuery) : base("LOAISP", pQuery) { }
    }
}