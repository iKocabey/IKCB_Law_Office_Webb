using BusinessLayer.Abstract;
using DataAcceessLayer.Abstract;
using DataAcceessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class tblPersonelManager:IPersonelService
    {
        IPersonelDal _personelDal;

        public tblPersonelManager(IPersonelDal personel)
        {
            _personelDal = personel;
        }

        public void FileAdd(tblPersonel tblpersonel)
        {
            _personelDal.Insert(tblpersonel);
        }

        public void FileDelete(tblPersonel tblpersonel)
        {
            _personelDal.Delete(tblpersonel);
        }

        public void FileUpdate(tblPersonel tblpersonel)
        {
            _personelDal.Update(tblpersonel);
        }

        public tblPersonel GetById(int id)
        {
            return _personelDal.Get(x => x.perId == id);
        }

        public List<tblPersonel> GetList()
        {
            return _personelDal.List();
        }

        public List<tblPersonel> GetlistByUser(int id)
        {
            return _personelDal.List(x => x.perId == id);
        }
    }
}
