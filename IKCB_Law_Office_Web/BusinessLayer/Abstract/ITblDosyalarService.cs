using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITblDosyalarService
    {
        List<tblDosyalar> GetList();
        void FileAdd(tblDosyalar tbldosyalar);
        List<tblDosyalar> GetlistByUser(int id);
        void FileDelete(tblDosyalar tbldosyalar);
        void FileUpdate(tblDosyalar tbldosyalar);
        tblDosyalar GetById(int id);
            
    }

}
