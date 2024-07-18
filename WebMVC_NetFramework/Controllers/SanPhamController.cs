using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC_NetFramework.Models;

namespace WebMVC_NetFramework.Controllers
{
    public class SanPhamController : Controller
    {
        
        // GET: SanPham
        public ActionResult Index(string SearchText = "")          
        {

            var lstSanPham = new DBSanPhamContext().SanPhams.ToList();
            return View(lstSanPham);
        }

        // GET: SanPham/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SanPham/Create
        public ActionResult Create()
        {
            var context = new DBSanPhamContext();
            var danhMucSelect = new SelectList(context.DanhMucSanPhams, "IDDanhMuc", "TenDanhMuc");
            ViewBag.IDDanhMuc = danhMucSelect;
            return View();          
        }

        // POST: SanPham/Create
        [HttpPost]
        public ActionResult Create(SanPham model)
        {
            // TODO: Add insert logic here
           
            try
            {
                var context = new DBSanPhamContext();

                context.SanPhams.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SanPham/Edit/5
        public ActionResult Edit(int id)
        {

            return View();
        }

        // POST: SanPham/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SanPham/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SanPham/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


    }
}
