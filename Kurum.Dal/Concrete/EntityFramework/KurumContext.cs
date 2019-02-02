using Kurum.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Kurum.Dal.Concrete.EntityFramework
{
    public class KurumContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
