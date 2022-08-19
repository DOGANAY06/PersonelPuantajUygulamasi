using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonelPuantajUygulamasi.Models;

namespace PersonelPuantajUygulamasi.Controllers
{
    public class Vardiya : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public IActionResult Liste()
        {
            ViewBag.Vardiya = db.Vardiyas.ToList();
            //departmanlar listenelexccek 
            return View();
        }
        [HttpPost]
        public IActionResult Kaydet(Models.Vardiya V)
        {
            db.Vardiyas.Add(V);
            db.SaveChanges();
            return RedirectToAction("Liste");
        }
        [HttpPost]
        public IActionResult Duzenle(Models.Vardiya V)
        {
            Models.Vardiya VA = db.Vardiyas.FirstOrDefault(x => x.Id == V.Id);
            VA.Ad = V.Ad;
            db.SaveChanges();
            return RedirectToAction("Liste");
        }

        public IActionResult Sil(int Id)
        {
            Models.Vardiya dbsil = db.Vardiyas.FirstOrDefault(x => x.Id == Id); //ide göre değeri getir)
            db.Vardiyas.Remove(dbsil);
            db.SaveChanges();
            return RedirectToAction("Liste");
        }
    }
}
