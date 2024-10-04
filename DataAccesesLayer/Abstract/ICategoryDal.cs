using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesesLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Tbl_Category>
    {
      /*  List<Tbl_Category> ListAllCategory();
        void AddCategory(Tbl_Category category);
        void DeleteCategory(Tbl_Category category);
        void UpdateCategory(Tbl_Category category);

        Tbl_Category GetById(int id);  bunları genericten alıyoruz */


    }
}
