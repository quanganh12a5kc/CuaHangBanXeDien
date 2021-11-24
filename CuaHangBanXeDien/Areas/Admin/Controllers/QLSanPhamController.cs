using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CuaHangBanXeDien.Models;
using CuaHangBanXeDien.BUS;

namespace CuaHangBanXeDien.Areas.Admin.Controllers
{
    public class QLSanPhamController : Controller
    {
        SanPhamBUS spb = new SanPhamBUS();
        // GET: Admin/QLSanPham
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetAllProduct()
        {
            List<SanPham> lp = spb.GetProducts();
            return Json(new { sp = lp }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult AddProduct(SanPham s)
        {
            spb.AddProduct(s);
            return Json("Them", JsonRequestBehavior.AllowGet);
        }
        public JsonResult EditProduct(SanPham s)
        {
            spb.EditProduct(s);
            return Json("Sua", JsonRequestBehavior.AllowGet);
        }
        public JsonResult DeleteProduct(string id)
        {
            spb.DeleteProduct(id);
            return Json("Xoa", JsonRequestBehavior.AllowGet);
        }
    }
}