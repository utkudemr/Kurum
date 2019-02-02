using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurum.Entities
{
    public class Cart
    {
        List<CartLine> _lines = new List<CartLine>();
        public void AddToCart(Product product, int quantity)
        {
            //CartLine da ürünün eklimi diye kontrol ediyor.
            CartLine cartLine = _lines.FirstOrDefault(c => c.Product.ProductID == product.ProductID);
            if (cartLine == null)
            {
                //cartline yoksa yeni ürün ekliyor.
                _lines.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                cartLine.Quantity += quantity;
            }
        }
        public void RemoveFromCard(Product product)
        {
            _lines.RemoveAll(p => p.Product.ProductID == product.ProductID);
            //Remove ilk bulduğu elemanı siler removeall bulduğu bütün elemanları siler.
        }
        public decimal Total
        {
            get
            {
                return _lines.Sum(c => c.Product.UnitPrice * c.Quantity);
            }
        }
        public void Clear() { _lines.Clear(); }//Sepeti temizle

       public List<CartLine> Lines
        {
            get { return _lines; }
        }
    }
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
