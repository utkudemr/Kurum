using Kurum.Dal.Abstract;
using Kurum.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurum.Dal.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        private KurumContext _context = new KurumContext();


        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }
        public Product Get(int productId)
        {
            return _context.Products.FirstOrDefault(p => p.ProductID == productId);
        }
        public void Add(Product product)
        {
             _context.Products.Add(product);
        }

        public void Delete(int productId)
        {
            _context.Products.Remove(_context.Products.FirstOrDefault(p => p.ProductID == productId));
        }
        
        public void Update(Product product)
        {
            var productToUpdate = _context.Products.FirstOrDefault(p => p.CategoryId == product.CategoryId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;

            _context.SaveChanges();
        }
    }
}
