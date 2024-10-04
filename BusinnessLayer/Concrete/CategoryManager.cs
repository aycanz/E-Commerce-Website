using BusinnessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesesLayer.Repositories;
using DataAccesesLayer.EntityFramework;
using DataAccesesLayer.Abstract;

/*Business kat. abstract klasörü içindekiler service olarak adlandırılıyor 
 * Bk concrate içindeki sınıflar manager olarak adlandırılır */

namespace BusinnessLayer.Concrete
{
    
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        
     
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Tbl_Category categoryName)
        {
            _categoryDal.Insert(categoryName);       }

        public void CategoryDelete(Tbl_Category categoryName)
        {
            _categoryDal.Delete(categoryName);
          }

        public void CategoryUpdate(Tbl_Category categoryName)
        {
            _categoryDal.Update(categoryName);    
        }

        public List<Tbl_Category> GetAllCategories()
        {
          return _categoryDal.GetAll();
        }

        public Tbl_Category GetCategoryById(int id)
        {
          return _categoryDal.GetByID(id);
        }
    }
     
}
