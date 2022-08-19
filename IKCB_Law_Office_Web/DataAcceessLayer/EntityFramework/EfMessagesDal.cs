using DataAcceessLayer.Abstract;
using DataAcceessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceessLayer.EntityFramework
{
    public class EfMessagesDal: GenericRepository<tblMessage>, IMessageDal
    {

    }
}
