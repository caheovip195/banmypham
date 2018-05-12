using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BanHangOnline.Controllers
{
    public class TheLoaiController : ApiController
    {
        [HttpGet]
        public List<TheLoai> dstl()
        {
            BanHangOnlineDataContext context = new BanHangOnlineDataContext();
            List<TheLoai> ds = context.TheLoais.ToList();
            foreach(TheLoai tl in ds)
            {
                tl.SanPhams=null;
            }
            return ds;
        }
    }
}
