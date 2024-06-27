using ExamWeb_NguyenThanhSon.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWeb_LeVanTeo.Models;
namespace ExamWeb_NguyenThanhSon.Controllers
{
    public class DiaNhacController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DiaNhacController(ApplicationDbContext db)
        {
            _db = db;
        }

        //hiển thị list
        public IActionResult Index()
        {
            var dsBook = _db.DiaNhacs.ToList();
            var tongsoluong = _db.DiaNhacs.Sum(x => x.SoLuong);
            ViewBag.SUM = tongsoluong;
            return View(dsDiaNhac);
        }
        //hiển thị giao diện thêm DiaNhac
        public IActionResult Add() {
            return View();
        }

        //xử lý thêm 
        [HttpPost]
        public IActionResult Add(DiaNhac dianhac)
        {
            if (ModelState.IsValid)
            {
                _db.DiaNhacs.Add(dianhac);
                _db.SaveChanges();
                TempData["success"] = "Đã thêm 1 ";
                return RedirectToAction("Index");
            }
            return View(dianhac);
        }

        //hiển thị giao diện cập nhật 
        public IActionResult Update(int id)
        {
            //var dianhac = _db.DiaNhacs.Find(id);
            var dianhac = _db.DiaNhacs.SingleOrDefault(x=>x.Id==id);
            if(dianhac!=null)
               return View(dianhac);

            return NotFound();
        }

        //xử lý sua 
        [HttpPost]
        public IActionResult Update(DiaNhac dianhac)
        {
            if (ModelState.IsValid)
            {
                _db.DiaNhacs.Update(dianhac);
                _db.SaveChanges();
                TempData["success"] = "Đã cập nhật 1 ";
                return RedirectToAction("Index");
            }
            return View(dianhac);
        }
    }
}
