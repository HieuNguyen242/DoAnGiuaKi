using ShopOnline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace _1460017_DAGK.Models.Bus
{
    public class SanPhamBus
    {
        public static IEnumerable<SanPham>DanhSach()
        {
            var db = new ShopOnlineDB();
            return db.Query<SanPham>("select * from SanPham");
        }
    }
}