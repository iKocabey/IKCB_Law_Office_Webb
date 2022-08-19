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
    public class tblMessageManager:IMessageService
    {
        IMessageDal _MessageDal;

        public tblMessageManager(IMessageDal messageDal)
        {
            _MessageDal = messageDal;
        }


        public tblMessage GetById(int id)
        {
            return _MessageDal.Get(x => x.MessageId == id);
        }

        public List<tblMessage> GetList()
        {
            return _MessageDal.List();
        }

        public List<tblMessage> GetlistByUser(int id)
        {
            return _MessageDal.List(x => x.MessageId == id);
        }


        public void MessageAdd(tblMessage tblmessage)
        {
            _MessageDal.Insert(tblmessage);
        }

        public void MessageDelete(tblMessage tblmessage)
        {
            _MessageDal.Delete(tblmessage);
        }

        public void MessageUpdate(tblMessage tblmessage)
        {
            _MessageDal.Update(tblmessage);
        }
        public List<tblMessage> GetListInBox(int id)
        {
            return _MessageDal.List(x => x.ReceiverId == id);
        }

        public List<tblMessage> GetListSendBox(int id)
        {
            return _MessageDal.List(x => x.SenderId == id);
        }
    }
}
