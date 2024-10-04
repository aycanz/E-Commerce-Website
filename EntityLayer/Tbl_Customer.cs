using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Tbl_Customer
    {
        [Key]
        public int UserId { get; set; }
        public string Username {  get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
             

    }
}
