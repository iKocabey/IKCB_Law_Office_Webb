using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceessLayer.Concrete
{
    public class Context:DbContext
    {
        public DbSet<tblDosyalar> tblDosyalars { get; set; }
        public DbSet<tblPersonel> tblPersonels { get; set; }
        public DbSet<tblKarsiTaraf> tblKarsiTarafs { get; set; }
        public DbSet<tblMuvekkiller> muvekkillers { get; set; }
        public DbSet<tblMessage> tblMessages { get; set; }
    }
}
