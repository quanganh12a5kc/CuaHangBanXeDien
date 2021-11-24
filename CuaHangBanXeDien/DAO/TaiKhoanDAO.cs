using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CuaHangBanXeDien.Models;
using System.Data;

namespace CuaHangBanXeDien.DAO
{
    public class TaiKhoanDAO
    {
        DataHelper dh = new DataHelper();
        public List<TaiKhoan> GetUser()
        {
            DataTable dt = dh.FillDataTable("select * from TaiKhoan");
            return ToList(dt);
        }
        public List<TaiKhoan> ToList(DataTable dt)
        {
            List<TaiKhoan> l = new List<TaiKhoan>();
            foreach (DataRow dr in dt.Rows)
            {
                TaiKhoan sp = new TaiKhoan();
                sp.MaU = dr["MaU"].ToString();
                sp.TenU = dr["TenU"].ToString();
                sp.Pass = dr["Pass"].ToString();
                sp.Role = dr["Role"].ToString();
                sp.Email = dr["Email"].ToString();
                sp.DiaChi = dr["DiaChi"].ToString();
                sp.Sdt = dr["Sdt"].ToString();
                l.Add(sp);
            }
            return l;
        }
        public TaiKhoan Login(string mau,string pass)
        {
            DataTable dt = dh.FillDataTable("select * from TaiKhoan where MaU='"+mau+"',Pass='"+pass+"'");
            if (dt.Rows.Count <= 0) return null;
            else
            {
                TaiKhoan us = new TaiKhoan();
                us.MaU = dt.Rows[0][0].ToString();
                us.TenU = dt.Rows[0][1].ToString();
                us.Pass = dt.Rows[0][2].ToString();
                us.Role = dt.Rows[0][3].ToString();
                us.Email = dt.Rows[0][4].ToString();
                us.DiaChi = dt.Rows[0][5].ToString();
                us.Sdt = dt.Rows[0][6].ToString();
                return us;
            }
        }
    }
}