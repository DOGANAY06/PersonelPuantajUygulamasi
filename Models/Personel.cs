using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelPuantajUygulamasi.Models
{
    public class Personel:Gunler
    {//günler nesnesinden miras aldık
        [Key]
        public int Id { get; set; }

        public int DepartmanId { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Telefon { get; set; }

        public decimal Maas { get; set; }
        public string Iban { get; set; }

    }
}
