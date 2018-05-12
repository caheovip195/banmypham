using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BanHangOnline.Controllers
{
    public class SanPhamController : ApiController
    {
        //trả về tất cả các sản phẩm
        [HttpGet]
        public List<SanPham> tatcasp()
        {
            BanHangOnlineDataContext context = new BanHangOnlineDataContext();
            List<SanPham> ds = context.SanPhams.ToList();
            foreach(SanPham sp in ds)
            {
                sp.TheLoai.MaTheLoai = -1;
            }
            return ds;
        }

        //Trả về danh sách sản phẩm theo thể  loại
        [HttpGet] 
        public List<SanPham> dstheotheloai(int id)
        {
            BanHangOnlineDataContext context = new BanHangOnlineDataContext();
            List<SanPham> dssp = context.SanPhams.Where(x => x.MaTheLoai == id).ToList();
            if (dssp != null)
            {
                foreach(SanPham sp in dssp)
                {
                    sp.TheLoai.MaTheLoai = -1;
                }
            }
            return dssp;
        }
        //Trả về list tìm kiếm được
        [HttpGet]
        public List<SanPham> timkiemtheoten(string ten)
        {
            BanHangOnlineDataContext context = new BanHangOnlineDataContext();
            List<SanPham> dsall = context.SanPhams.ToList();
            List<SanPham> dsloc = new List<SanPham>();
            foreach(SanPham sp in dsall)
            {
                sp.TheLoai.MaTheLoai = -1;
                if (sp.TenSP.Contains(ten))
                {
                    dsloc.Add(sp);
                }
            }
            return dsloc; 
        }
    }
}
