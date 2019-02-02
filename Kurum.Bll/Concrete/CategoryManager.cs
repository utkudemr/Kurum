using Kurum.Dal.Abstract;
using Kurum.Entities;
using Kurum.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurum.Bll.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
