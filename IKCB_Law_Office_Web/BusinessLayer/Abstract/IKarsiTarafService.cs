using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IKarsiTarafService
    {
        List<tblKarsiTaraf> GetList();
        void FileAdd(tblKarsiTaraf tblkarsitaraf);
        List<tblKarsiTaraf> GetlistByUser(int id);
        void FileDelete(tblKarsiTaraf tblkarsitaraf);
        void FileUpdate(tblKarsiTaraf tblkarsitaraf);
        tblKarsiTaraf GetById(int id);
    }
}
