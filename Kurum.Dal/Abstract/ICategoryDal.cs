using Kurum.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurum.Dal.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetAll();

    }
}
