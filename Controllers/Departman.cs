using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonelPuantajUygulamasi.Models;

namespace PersonelPuantajUygulamasi.Controllers
{
    public class Departman : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public IActionResult Liste()
        {
            ViewBag.Departman = db.Departmans.ToList();
            //departmanlar listenelexccek 

            return View();
        }
        [HttpPost]
        public IActionResult Kaydet(Models.Departman d)
        { //modelden gelen departmanı tuttuk
            db.Departmans.Add(d);
            db.SaveChanges();
            return RedirectToAction("Liste"); // kayıt olduktan sonra listeye gidicek
        }
        [HttpPost] //güvenlikle alakalı
        public IActionResult Duzenle(Models.Departman D)
        {//post methodu ile data getirdik
            Models.Departman ED = db.Departmans.FirstOrDefault(x => x.Id == D.Id); //ide göre değeri getir
            ED.Ad = D.Ad;
            ED.Aciklama = D.Aciklama;
            db.SaveChanges();
            return RedirectToAction("Liste");
        }

        public IActionResult Sil(int Id)
        {
            foreach (Models.Personel item in db.Personels.Where(x=>x.DepartmanId ==Id).ToList() ) //birden fazla personel var bu persoelleri sıralayıp kayıtlarını almam gerekiyor
            {
                if (item.DepartmanId==Id)
                {
                    item.DepartmanId = 1; //hangi personelin ıdsi esitse
                    db.SaveChanges();
                }
                
            }
            Models.Departman dbsil= db.Departmans.FirstOrDefault(x => x.Id == Id); //ide göre değeri getir)
            db.Departmans.Remove(dbsil);
            db.SaveChanges();
            return RedirectToAction("Liste");
        }
    }
}
