using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CuaHangBanXeDien.Models;
using CuaHangBanXeDien.DAO;

namespace CuaHangBanXeDien.BUS
{
    public class LoaiSPBUS
    {
        LoaiSPDAO lspd = new LoaiSPDAO();
        public List<LoaiSP> LayLoaiSP()
        {
            return lspd.LayLoaiSP();
        }
        public List<LoaiSP> LayTenLoai(string maloai)
        {
            return lspd.LayTenLoai(maloai);
        }
    }
}