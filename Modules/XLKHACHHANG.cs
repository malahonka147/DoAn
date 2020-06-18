using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace Lab4.Modules
{
    class XLKHACHHANG:XLBANG
    {

        public XLKHACHHANG() : base("KHACHHANG") { }
        public XLKHACHHANG(string pQuery) : base("KHACHHANG", pQuery) { }
    }
}