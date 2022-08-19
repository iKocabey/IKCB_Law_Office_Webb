using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMuvekkillerService
    {
        List<tblMuvekkiller> GetList();
        void FileAdd(tblMuvekkiller tblmuvekkiller);
        List<tblMuvekkiller> GetlistByUser(int id);
        void FileDelete(tblMuvekkiller tblmuvekkiller);
        void FileUpdate(tblMuvekkiller tblmuvekkiller);
        tblMuvekkiller GetById(int id);
    }
}
