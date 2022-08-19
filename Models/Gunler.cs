using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelPuantajUygulamasi.Models
{
    public class Gunler
    {//veritabanına basılmayacak personel içinde aktif olacak
        public string Pazartesi { get; set; }
        public string Sali { get; set; }
        public string Carsamba { get; set; }
        public string Persembe { get; set; }
        public string Cuma { get; set; }
        public string Cumartesi { get; set; }
        public string Pazar { get; set; }
    }
}
