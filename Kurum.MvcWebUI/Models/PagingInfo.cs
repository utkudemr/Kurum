using Kurum.Entities;
using Kurum.MvcWebUI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kurum.MvcWebUI.Models
{
    public class PagingInfo
    {
        public int ItemsPerPage { get; set; }
        public decimal TotalItems { get; set; }
        public int CurrentPage { get; set; }
        public int CurrentCategory { get; set; }
    }

}