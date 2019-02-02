
using Kurum.Bll.Concrete;
using Kurum.Dal.Abstract;
using Kurum.Dal.Concrete.EntityFramework;
using Kurum.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Kurum.MvcWebUI.Infrastructure
{
    public class NinjectControllerFactory:DefaultControllerFactory
    {
        private IKernel _ninjectkernel;
        public NinjectControllerFactory()
        {
            _ninjectkernel = new StandardKernel();
            AddBllBinding();
        }

        private void AddBllBinding()
        {
            //eğer ırpdocut service isteği varsa product managere yönlendir.ProductManager in constructurda parametreye ihtiyacı vardır.
            _ninjectkernel.Bind<IProductService>().To<ProductManager>().WithConstructorArgument("productDal",new EfProductDal());
            _ninjectkernel.Bind<ICategoryService>().To<CategoryManager>().WithConstructorArgument("categoryDal", new EfCategoryDal());

        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_ninjectkernel.Get(controllerType);
        }
    }
}