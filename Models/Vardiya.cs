using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonelPuantajUygulamasi.Models
{
    public class Vardiya
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }

    }
}
