using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BanHangMyPham.Controllers
{
    public class MatHangController : ApiController
    {
        //Tra ve tat ca san pham
        [HttpGet]
        public List<MatHang> dsmathang()
        {
            QuanLyMyPhamDataContext context = new QuanLyMyPhamDataContext();
            List<MatHang> ds = context.MatHangs.ToList();
            foreach(MatHang mh in ds)
                mh.TheLoai = null;
            return ds;
        }
    }
}
