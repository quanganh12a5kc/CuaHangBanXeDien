using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CuaHangBanXeDien.Models;
using System.Data;

namespace CuaHangBanXeDien.DAO
{
    public class LoaiSPDAO
    {
        DataHelper dh = new DataHelper();
        public List<LoaiSP> LayLoaiSP()
        {
            DataTable dt = dh.FillDataTable("select * from LoaiSP");
            return ToList(dt);
        }
        public List<LoaiSP> ToList(DataTable dt)
        {
            List<LoaiSP> l = new List<LoaiSP>();
            foreach (DataRow dr in dt.Rows)
            {
                LoaiSP sp = new LoaiSP();
                sp.MaLoai = dr["MaLoai"].ToString();
                sp.TenLoai = dr["TenLoai"].ToString();
                sp.MoTa = dr["MoTa"].ToString();
                l.Add(sp);
            }
            return l;
        }
        public List<LoaiSP> LayTenLoai(string maloai)
        {
            DataTable dt = dh.FillDataTable("select * from LoaiSP where MaLoai='"+maloai+"'");
            return ToList(dt);
        }
    }
}