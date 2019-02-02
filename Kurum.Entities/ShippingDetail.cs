using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurum.Entities
{
   public class ShippingDetail
    {
        [Required(ErrorMessage ="İsim soyisim girmek zorunludur.")]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(10)]
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }

        public string City { get; set; }
        public string Country { get; set; }
        public Boolean IsGift { get; set; }



    }
}
