using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonelPuantajUygulamasi.Models;

namespace PersonelPuantajUygulamasi.Controllers
{
    public class Personel : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public IActionResult Liste()
        {
            ViewBag.Personel = db.Personels.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Models.Personel P)
        {
            db.Personels.Add(P);
            db.SaveChanges();
            return RedirectToAction("Liste");
        }

        public IActionResult Duzenle(Models.Personel P)
        {
            Models.Personel EP = db.Personels.FirstOrDefault(x => x.Id == P.Id);
            EP.DepartmanId = P.DepartmanId;
            EP.Ad = P.Ad;
            EP.Soyad = P.Soyad;
            EP.Telefon = P.Telefon;
            EP.Maas = P.Maas;
            EP.Iban = P.Iban;
            db.SaveChanges();
            return RedirectToAction("Liste");
        }

        public IActionResult Sil(int Id)
        {
            Models.Personel silinecek = db.Personels.FirstOrDefault(x => x.Id == Id);
            db.Personels.Remove(silinecek);
            db.SaveChanges();
            return RedirectToAction("Liste");
        }
    }
}
