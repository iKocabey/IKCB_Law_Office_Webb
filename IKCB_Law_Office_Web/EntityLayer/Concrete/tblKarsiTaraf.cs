using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class tblKarsiTaraf
    {
        [Key]
        public int karsiTarafId { get; set; }
        [StringLength(50)]
        public string karsiTaradAdSoyad { get; set; }
        [StringLength(12)]
        public string karsiTarafkimlikNo { get; set; }
        [StringLength(20)]
        public string karsiTarafVergiNo { get; set; }
        [StringLength(20)]
        public string karsiTarafSicilNo { get; set; }
        [StringLength(7)]
        public string karsiTarafCinsiyet { get; set; }
        [StringLength(12)]
        public string karsiTarafTelefonNo { get; set; }
        [StringLength(50)]
        public string karsiTarafEposta { get; set; }
        [StringLength(500)]
        public string karsiTarafAdres { get; set; }

        public ICollection<tblDosyalar> tblDosyalars { get; set; }

    }
}
