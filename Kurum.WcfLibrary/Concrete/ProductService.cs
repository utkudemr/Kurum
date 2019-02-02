﻿using Kurum.Bll.Concrete;
using Kurum.Dal.Concrete.EntityFramework;
using Kurum.Entities;
using Kurum.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurum.WcfLibrary.Concrete
{
    public class ProductService : IProductService
    {
        //service uygulamalarında constructor yapısı olmaz..
        private ProductManager _productManager = new ProductManager(new EfProductDal());

        public void Add(Product product)
        {
            _productManager.Add(product);
        }

        public void Delete(int productId)
        {
            _productManager.Delete(productId);
        }

        public Product Get(int productId)
        {
            return _productManager.Get(productId);
        }

        public List<Product> GetAll()
        {
            return _productManager.GetAll();
        }

        public void Update(Product product)
        {
            _productManager.Update(product);
        }
    }
}
