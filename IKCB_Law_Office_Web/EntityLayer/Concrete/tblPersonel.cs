using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class tblPersonel
    {
        [Key]
        public int perId { get; set; }
      
        [StringLength(50)]
        public string perAdiSoyadi { get; set; }
        [StringLength(50)]
        public string perEmailAdres { get; set; }
        [StringLength(12)]
        public string perTelno { get; set; }
        [StringLength(500)]
        public string perAdres { get; set; }
        [StringLength(20)]
        public string perSifre { get; set; }
        public DateTime perDogTar  { get; set; }
        public string perProfilFoto { get; set; }
        [StringLength(12)]
        public string perTc { get; set; }
        public bool perYetkiMaliRapor { get; set; }
        public bool perYetkiAvansMasraf { get; set; }
        [StringLength(50)]
        public string perPozisyon { get; set; }
        public virtual tblMessage TblMessage { get; set; }
    }
}
