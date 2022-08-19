using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class tblMuvekkiller
    {
        [Key]
        public int muvekkilId { get; set; }
        [StringLength(50)]
        public string muvekkilAdSoyad { get; set; }
        [StringLength(12)]
        public string muvekkilKimlikNo { get; set; }
        [StringLength(20)]
        public string muvekkilVergiNo { get; set; }
        [StringLength(20)]
        public string muvekkilSicilNo { get; set; }
        [StringLength(8)]
        public string muvekkilCinsiyet{ get; set; }
        [StringLength(12)]
        public string muvekkilTelefonNo { get; set; }
        [StringLength(50)]
        public string muvekkilEposta{ get; set; }
        [StringLength(500)]
        public string muvekkilAdres { get; set; }
        public ICollection<tblDosyalar> tblDosyalars { get; set; }


    }
}
