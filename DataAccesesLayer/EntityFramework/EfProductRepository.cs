using DataAccesesLayer.Abstract.Iproduct;
using DataAccesesLayer.Concrete;
using DataAccesesLayer.Repositories;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesesLayer.EntityFramework
{
    public class EfProductRepository : GenericRepository<Tbl_Product>, IProductDal
    {
        public Tbl_Product GetByID(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
        public Tbl_Product GetByIDWithCategory(int id)
        {
            using (var c = new Context())
            {
                return c.Tbl_Products.Include((a) => a.Category).FirstOrDefault(x => x.ProductId == id);

             //   return c.Tbl_Products.Where(x => x.ProductId == id).Include((a) => a.Category).FirstOrDefault();

            }
           
        }

        public List<Tbl_Product> GetListWithCategory()
        {
            using(var c=new Context())
            {
            return c.Tbl_Products.Include((p) => p.Category).ToList();
            }
         }
    }
}
