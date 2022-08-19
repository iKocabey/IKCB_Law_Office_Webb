using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class tblDosyalar
    {
        [Key]
        public int dosyaId { get; set; }
        [StringLength(50)]
        public string dosyaTuru { get; set; }
        [StringLength(50)]
        public string davaVeyaTakipTuru { get; set; }
        [StringLength(50)]
        public string mahkemeTuruVeyaTakipYolu { get; set; }
        [StringLength(50)]
        public string mahkemeTuruAltKirilim { get; set; }
        [StringLength(50)]
        public string leyhdeAleyhde { get; set; }
        [StringLength(20)]
        public string tarafimiz { get; set; }
        [StringLength(20)]
        public string klasorNo { get; set; }
        [StringLength(20)]
        public string dosyaNo { get; set; }
        [StringLength(50)]
        public string mahkemesiVeyaDairesi { get; set; }
        [StringLength(50)]
        public string davaVeyaIcraKonusu { get; set; }
        public DateTime davaAcmaTarihi { get; set; }
        public DateTime isKabulTarihi { get; set; }
        [StringLength(20)]
        public string esas { get; set; }
        [StringLength(20)]
        public string dosyaDurum { get; set; }
        [StringLength(20)]
        public string davaDurum { get; set; }

        public int perId { get; set; }
        public virtual tblPersonel TblPersonel { get; set; }

        public int muvekkilId { get; set; }
        public virtual tblMuvekkiller TblMuvekkiller { get; set; }

        public int karsiTarafId { get; set; }
        public virtual tblKarsiTaraf TblKarsiTaraf{ get; set; }

    }
}