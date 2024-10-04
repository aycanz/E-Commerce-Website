using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesesLayer.Abstract
{
    public interface ICustomerDal : IGenericDal<Tbl_Customer>
    {
        void Add(Tbl_Customer entity);
    }
}
