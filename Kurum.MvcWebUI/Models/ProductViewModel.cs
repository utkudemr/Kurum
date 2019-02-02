using Kurum.Entities;
using Kurum.MvcWebUI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kurum.MvcWebUI.Models
{
   public class ProductViewModel
    {
        public List<Product> Product { get; set; }
        public PagingInfo PaggingInfo { get; set; }
    }
}