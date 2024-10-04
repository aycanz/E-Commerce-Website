using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesesLayer.Abstract.Iproduct
{
    public interface IProductDal:IGenericDal<Tbl_Product>
    {
        Tbl_Product GetByID(Func<object, bool> value);
        List<Tbl_Product> GetListWithCategory();
        public Tbl_Product GetByIDWithCategory(int id);


    }
}
