using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete.Contact;

namespace DataAccessLayer.EntityFramework
{
   public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
    }
}
