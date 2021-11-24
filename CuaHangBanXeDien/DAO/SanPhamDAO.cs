using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CuaHangBanXeDien.Models;
using System.Data;

namespace CuaHangBanXeDien.DAO
{
    public class SanPhamDAO
    {
        DataHelper dh = new DataHelper();
        public List<SanPham> GetProduct()
        {
            DataTable dt = dh.FillDataTable("select * from SanPham");
            return ToList(dt);
        }
        public List<SanPham> ToList(DataTable dt)
        {
            List<SanPham> l = new List<SanPham>();
            foreach (DataRow dr in dt.Rows)
            {
                SanPham sp = new SanPham();
                sp.MaSP = dr["MaSP"].ToString();
                sp.TenSP = dr["TenSP"].ToString();
                sp.MaLoai = dr["MaLoai"].ToString();
                sp.SoLuong = int.Parse(dr["SoLuong"].ToString());
                sp.MoTa = dr["MoTa"].ToString();
                sp.Anh = dr["Anh"].ToString();
                sp.Gia = dr["Gia"].ToString();
                sp.Sale = dr["Sale"].ToString();
                l.Add(sp);
            }
            return l;
        }
        public List<SanPham> LaySanPhamTheoLoai(string maloai)
        {
            string sqlselect;
            if (maloai != "")
            {
                sqlselect = "select * from SanPham where MaLoai = '" + maloai + "'";
            }
            else
            {
                sqlselect = "select * from SanPham";
            }
            DataTable dt = dh.FillDataTable(sqlselect);
            return ToList(dt);
        }
        public List<SanPham> LaySanPhamTheoMaSP(string masp)
        {
            return ToList(dh.FillDataTable("select * from SanPham where MaSP = '" + masp + "'"));
        }
        public void AddProduct(SanPham sp)
        {
            sp.MaSP = sp.MaSP.Trim().ToUpper();
            string sql = "INSERT into SanPham values('" + sp.MaSP + "','" + sp.TenSP + "','" + sp.MaLoai + "','" + sp.SoLuong + "','" + sp.MoTa + "','" + sp.Anh + "','" + sp.Gia + "','" + sp.Sale + "')";
            dh.ExecuteNonQuery(sql);
        }
        public void DeleteProduct(string id)
        {
            string sql = "delete from SanPham where MaSP = '" + id + "'";
            dh.ExecuteNonQuery(sql);
        }
        public void EditProduct(SanPham sp)
        {
            sp.MaSP = sp.MaSP.Trim().ToUpper();
            string sql = "update SanPham set TenSP = '" + sp.TenSP + "', MaLoai = '" + sp.MaLoai + "', SoLuong = '" + sp.SoLuong + "', DonVi = '" + sp.MoTa + "', Mota = '" + sp.Anh + "',Anh='" + sp.Gia + "',AnhTo='" + sp.Sale + "' where MaSP = '" + sp.MaSP + "'";
            dh.ExecuteNonQuery(sql);
        }
    }
}