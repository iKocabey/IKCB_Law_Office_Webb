using BusinessLayer.Abstract;
using DataAcceessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class tblKarsiTarafManager:IKarsiTarafService
    {
        IKarsiTarafDal _KarsiTarafDal;

        public tblKarsiTarafManager(IKarsiTarafDal karsiTarafDal)
        {
            _KarsiTarafDal = karsiTarafDal;
        }

        public void FileAdd(tblKarsiTaraf tblkarsitaraf)
        {
            _KarsiTarafDal.Insert(tblkarsitaraf);
        }

        public void FileDelete(tblKarsiTaraf tblkarsitaraf)
        {
            _KarsiTarafDal.Delete(tblkarsitaraf);
        }

        public void FileUpdate(tblKarsiTaraf tblkarsitaraf)
        {
            _KarsiTarafDal.Update(tblkarsitaraf);
        }

        public tblKarsiTaraf GetById(int id)
        {
            return _KarsiTarafDal.Get(x => x.karsiTarafId == id);
        }

        public List<tblKarsiTaraf> GetList()
        {
            return _KarsiTarafDal.List();
        }

        public List<tblKarsiTaraf> GetlistByUser(int id)
        {
            return _KarsiTarafDal.List(x => x.karsiTarafId == id);
        }
    }
}