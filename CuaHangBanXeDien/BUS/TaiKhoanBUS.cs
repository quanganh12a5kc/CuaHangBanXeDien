using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CuaHangBanXeDien.DAO;
using CuaHangBanXeDien.Models;
namespace CuaHangBanXeDien.BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAO tkd = new TaiKhoanDAO();
        public TaiKhoan CheckUser(string mau,string pass)
        {
            return tkd.Login(mau, pass);
        }
    }
}