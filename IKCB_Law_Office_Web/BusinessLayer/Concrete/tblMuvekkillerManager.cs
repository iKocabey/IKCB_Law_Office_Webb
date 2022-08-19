using BusinessLayer.Abstract;
using DataAcceessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class tblMuvekkillerManager : IMuvekkillerService
    {
        IMuvekkillerDal _MuvekkillerDal;

        public tblMuvekkillerManager(IMuvekkillerDal muvekkiller)
        {
            _MuvekkillerDal = muvekkiller;
        }
        public void FileAdd(tblMuvekkiller tblmuvekkiller)
        {
            _MuvekkillerDal.Insert(tblmuvekkiller);
        }

        public void FileDelete(tblMuvekkiller tblmuvekkiller)
        {
            _MuvekkillerDal.Delete(tblmuvekkiller);
        }

        public void FileUpdate(tblMuvekkiller tblmuvekkiller)
        {
            _MuvekkillerDal.Update(tblmuvekkiller);
        }

        public tblMuvekkiller GetById(int id)
        {
            return _MuvekkillerDal.Get(x => x.muvekkilId == id);
        }

        public List<tblMuvekkiller> GetList()
        {
            return _MuvekkillerDal.List();
        }

        public List<tblMuvekkiller> GetlistByUser(int id)
        {
            return _MuvekkillerDal.List(x=>x.muvekkilId==id);
        }
    }
}
