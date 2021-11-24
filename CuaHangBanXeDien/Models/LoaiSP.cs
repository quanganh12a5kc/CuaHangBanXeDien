using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CuaHangBanXeDien.Models
{
    public class LoaiSP
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string MoTa { get; set; }
        public LoaiSP()
        {

        }
        public LoaiSP(string maloai,string tenloai,string mota)
        {
            this.MaLoai = maloai;
            this.TenLoai = tenloai;
            this.MoTa = mota;
        }
    }
}