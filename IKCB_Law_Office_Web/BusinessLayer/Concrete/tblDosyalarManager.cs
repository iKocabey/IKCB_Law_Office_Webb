using BusinessLayer.Abstract;
using DataAcceessLayer.Abstract;
using DataAcceessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class tblDosyalarManager : ITblDosyalarService
    {
        
       
        IDosyalarDal _DosyalarDal;

        public tblDosyalarManager(IDosyalarDal dosyalarDal)
        {
            _DosyalarDal = dosyalarDal;
        }

        public void FileAdd(tblDosyalar tbldosyalar)
        {
            _DosyalarDal.Insert(tbldosyalar);
        }

        public void FileDelete(tblDosyalar tbldosyalar)
        {
            _DosyalarDal.Delete(tbldosyalar);
        }

        public void FileUpdate(tblDosyalar tbldosyalar)
        {
            _DosyalarDal.Update(tbldosyalar);
        }

        public tblDosyalar GetById(int id)
        {
            return _DosyalarDal.Get(x => x.dosyaId == id);
        }

        public List<tblDosyalar> GetList()
        {
            return _DosyalarDal.List();
        }

        public List<tblDosyalar> GetlistByUser(int id)
        {
            return _DosyalarDal.List(x => x.perId == id);
        }
    }
}
