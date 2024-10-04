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
   public class EfCategoryRepository :GenericRepository <Tbl_Category>,ICategoryDal
    {

    }
}
