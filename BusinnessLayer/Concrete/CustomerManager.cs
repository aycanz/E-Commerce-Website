using BusinnessLayer.Abstract;
using DataAccesesLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Concrete
{
    public class CustomerManager:ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            this._customerDal = customerDal;
        }

        public void CustomerAdd(Tbl_Customer customer)
        {
            _customerDal.Insert(customer);
         }
    }
}
