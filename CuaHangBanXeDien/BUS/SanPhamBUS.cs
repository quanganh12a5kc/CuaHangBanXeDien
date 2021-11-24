using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CuaHangBanXeDien.Models;
using CuaHangBanXeDien.DAO;

namespace CuaHangBanXeDien.BUS
{
    public class SanPhamBUS
    {
        SanPhamDAO spd = new SanPhamDAO();
        public List<SanPham> GetProducts()
        {
            return spd.GetProduct();
        }
        public List<SanPham> LaySanPhamTheoLoai(string maloai)
        {
            return spd.LaySanPhamTheoLoai(maloai);
        }
        public List<SanPham> LaySanPhamTheoMaSP(string masp)
        {
            return spd.LaySanPhamTheoMaSP(masp);
        }
        public void AddProduct(SanPham s)
        {
            spd.AddProduct(s);
        }
        public void DeleteProduct(string id)
        {
            spd.DeleteProduct(id);

        }
        public void EditProduct(SanPham s)
        {
            spd.EditProduct(s);
        }
    }
}