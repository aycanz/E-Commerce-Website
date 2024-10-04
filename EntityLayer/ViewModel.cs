using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ViewModel
    {
        public IEnumerable<Tbl_Category> Tbl_Category { get; set; }
        public IEnumerable<Tbl_Product> Tbl_Product { get; set; }
    }
}