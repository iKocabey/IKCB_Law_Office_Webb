using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageService
    {
      
        //Burası interface ye eklenecek
        List<tblMessage> GetListInBox(int p);
        List<tblMessage> GetListSendBox(int p);
        List<tblMessage> GetList();
        void MessageAdd(tblMessage tblmessage);
        List<tblMessage> GetlistByUser(int id);
        void MessageDelete(tblMessage tblmessage);
        void MessageUpdate(tblMessage tblmessage);
        tblMessage GetById(int id);
    }
}
