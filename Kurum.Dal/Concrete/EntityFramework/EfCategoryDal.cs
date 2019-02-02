
using Kurum.Dal.Abstract;
using Kurum.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurum.Dal.Concrete.EntityFramework
{
    public class EfCategoryDal:ICategoryDal
    {
        KurumContext _kurumContext = new KurumContext();
       
        public List<Category> GetAll() {
            return _kurumContext.Categories.ToList();
        }

    }
}
