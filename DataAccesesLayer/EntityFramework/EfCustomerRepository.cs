using DataAccesesLayer.Abstract;
using DataAccesesLayer.Repositories;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesesLayer.EntityFramework
{
    public class EfCustomerRepository : GenericRepository<Tbl_Customer>, ICustomerDal
    {
        public void Add(Tbl_Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
