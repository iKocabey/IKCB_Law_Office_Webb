using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TblDosyalarValidator:AbstractValidator<tblDosyalar>
    {
        public TblDosyalarValidator()
        {
            RuleFor(x => x.dosyaNo).NotEmpty().WithMessage("Bu alan boş geçilemez.");
            RuleFor(x => x.klasorNo).NotEmpty().WithMessage("Bu alan boş geçilemez.");
            RuleFor(x => x.mahkemesiVeyaDairesi).NotEmpty().WithMessage("Bu alan boş geçilemez.");
            RuleFor(x => x.davaVeyaIcraKonusu).NotEmpty().WithMessage("Bu alan boş geçilemez.");

        }

    }
}
