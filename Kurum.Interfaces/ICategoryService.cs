using Kurum.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Kurum.Interfaces
{
    [ServiceContract]
    public interface ICategoryService
    {
        [OperationContract]
        List<Category> GetAll();
    }
}
