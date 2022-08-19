using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonelPuantajUygulamasi.Models;

namespace PersonelPuantajUygulamasi.Controllers
{
    public class Puantaj : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public IActionResult Liste()
        {
            ViewBag.PP = db.Personels.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Kaydet(Models.Personel P)
        {//modelden Personel geliyor
            Models.Personel EP = db.Personels.FirstOrDefault(x => x.Id == P.Id);
            //personeli aldık 
            EP.Pazartesi = P.Pazartesi;
            EP.Sali = P.Sali;
            EP.Carsamba = P.Carsamba;
            EP.Persembe = P.Persembe;
            EP.Cuma = P.Cuma;
            EP.Cumartesi = P.Cumartesi;
            EP.Pazar = P.Pazar;
            db.SaveChanges();
            return RedirectToAction("Liste");


        }
    }
}
