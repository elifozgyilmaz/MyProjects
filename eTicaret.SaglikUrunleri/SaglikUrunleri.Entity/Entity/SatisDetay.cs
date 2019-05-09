﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaglikUrunleri.Entity.Entity
{
    [Table("SatisDetaylar")]
    public class SatisDetay : EntityBase
    {
        public SatisDetay()
        {
            this.adet = 1;
            this.birimFiyat = 0;
            this.tutar = 0;
        }
        [Required]
        public int SatisID { get; set; }
        [Required]
        public int UrunID { get; set; }
        [Required]
        public int adet { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal birimFiyat { get; set; }
        [Column(TypeName = "money")]
        public decimal tutar { get; set; }

        //Relations
        public virtual Satis Satis { get; set; }
        public virtual Urun Urun { get; set; }
    }

}
