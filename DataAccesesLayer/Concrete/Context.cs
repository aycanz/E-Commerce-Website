using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesesLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = AYCAN; Initial Catalog = Db_Karpuz; Integrated Security = True;TrustServerCertificate=True");
        }


        public DbSet<Tbl_Category>Tbl_Categories { get; set; }
        public DbSet<Tbl_Product> Tbl_Products { get; set; }

        public DbSet<Tbl_Customer> Tbl_Customers { get; set;}

    }
}
