using DataAccesesLayer.Abstract.Iproduct;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinnessLayer.Concrete;

namespace BusinnessLayer.Abstract
{
    public interface IProductService
    {
        void ProductAdd(Tbl_Product ProductName);
        void ProductDelete(Tbl_Product ProductName);
        void ProductUpdate(Tbl_Product ProductName);

        List<Tbl_Product> GetAllProduct();

        Tbl_Product GetProductById(int id);

        List<Tbl_Product> GetProductListWithCategory();
 
    }
}
