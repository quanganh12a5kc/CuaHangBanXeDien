using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CuaHangBanXeDien.Models
{
    public class TaiKhoan
    {
        public string MaU { get; set; }
        public string TenU { get; set; }
        public string Pass { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public TaiKhoan() { }
    }
}