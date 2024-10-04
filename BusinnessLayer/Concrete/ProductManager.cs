using BusinnessLayer.Abstract;
using DataAccesesLayer.Abstract.Iproduct;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Concrete
{
    public class ProductManager : IProductService
    {
       public IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Tbl_Product> GetAllProduct()
        {
            return _productDal.GetAll();
        }

        public List<Tbl_Product> GetProductListWithCategory()
        {
           return _productDal.GetListWithCategory ();
        }

        public List<Tbl_Product>GetProductsById(int id)
        {

            var p = _productDal.GetByID(id);
            return _productDal.GetAll(x=>x.ProductId == id);
        }
        public Tbl_Product GetProductWithCategory(int id)
        {
            var pro= _productDal.GetByIDWithCategory(id);
            return _productDal.GetByIDWithCategory(id);
        }

        public Tbl_Product GetProductById(int id)
        {
            throw new NotImplementedException();

        }

        public void ProductAdd(Tbl_Product ProductName)
        {
            throw new NotImplementedException();
        }

        public void ProductDelete(Tbl_Product ProductName)
        {
            throw new NotImplementedException();
        }

        public void ProductUpdate(Tbl_Product ProductName)
        {
            throw new NotImplementedException();
        }
    }
}
