using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CuaHangBanXeDien.Models
{
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string MaLoai { get; set; }
        public int SoLuong { get; set; }
        public string MoTa { get; set; }
        public string Anh { get; set; }
        public string Gia { get; set; }
        public string Sale { get; set; }
        public SanPham(string masp, string tensp, string maloai, int soluong, string mota, string anh, string anhto,string gia,string sale)
        {
            this.MaSP = masp;
            this.TenSP = tensp;
            this.MaLoai = maloai;
            this.SoLuong = soluong;
            this.MoTa = mota;
            this.Anh = anh;
            this.Gia = gia;
            this.Sale = sale;
        }
        public SanPham()
        {

        }
    }
}