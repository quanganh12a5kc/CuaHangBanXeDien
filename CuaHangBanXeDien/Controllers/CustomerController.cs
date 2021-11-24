using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CuaHangBanXeDien.Models;
using CuaHangBanXeDien.BUS;
using Newtonsoft.Json;

namespace CuaHangBanXeDien.Controllers
{
    public class CustomerController : Controller
    {
        SanPhamBUS spb = new SanPhamBUS();
        LoaiSPBUS lspb = new LoaiSPBUS();
        TaiKhoanBUS tkb = new TaiKhoanBUS();
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TimKiemTheoLoai()
        {
            return View();
        }
        public ActionResult XemChiTietSanPham()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public PartialViewResult GetHeader()
        {
            return PartialView("_Header");
        }
        public PartialViewResult GetMenu()
        {
            return PartialView("_Menu");
        }
        public JsonResult GetProduct()
        {
            List<SanPham> lp = spb.GetProducts();
            return Json(new { sp = lp }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult LayLoaiSP()
        {
            List<LoaiSP> lp = lspb.LayLoaiSP();
            return Json(new { sp = lp }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult LaySanPhamTheoMaSP(string masp)
        {
            List<SanPham> lp = spb.LaySanPhamTheoMaSP(masp);
            return Json(new { sp = lp }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult LaySanPhamTheoMaLoai(string maloai)
        {
            List<SanPham> lp = spb.LaySanPhamTheoLoai(maloai);
            List<LoaiSP> l = lspb.LayTenLoai(maloai);
            string tenloai = l[0].TenLoai;
            Session.Add("tenloai",tenloai);
            return Json(new { sp = lp }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Logins(string us,string pass,bool rp)
        {
            TaiKhoan tk = tkb.CheckUser(us, pass);
            if (tk == null)
            {
                Session.Add("login", "0");
                Session.Add("khach", "");
            }
            else
            {
                if (!rp)
                {
                    tk.Pass = "";
                }
                Session.Add("login", "1");
                Session.Add("khach", JsonConvert.SerializeObject(tk));
                Session.Timeout = 360;
            }
            return Json(new { login = Session["login"] ,khach = tk}, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Logout()
        {
            Session.Remove("login");
            Session.Remove("khach");
            return Json(0, JsonRequestBehavior.AllowGet);
        }
    }
}