using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Abstract
{
    public interface ICategoryService
    {
        void CategoryAdd(Tbl_Category categoryName);
        void CategoryDelete(Tbl_Category categoryName);
        void CategoryUpdate(Tbl_Category categoryName);

        List<Tbl_Category> GetAllCategories();

        Tbl_Category GetCategoryById(int id);

    }
}
