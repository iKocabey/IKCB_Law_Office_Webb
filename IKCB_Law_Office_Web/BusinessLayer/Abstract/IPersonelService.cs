using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPersonelService
    {
        List<tblPersonel> GetList();
        void FileAdd(tblPersonel tblpersonel);
        List<tblPersonel> GetlistByUser(int id);
        void FileDelete(tblPersonel tblpersonel);
        void FileUpdate(tblPersonel tblpersonel);
        tblPersonel GetById(int id);
    }
}
