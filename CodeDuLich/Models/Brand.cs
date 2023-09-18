using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CodeDuLich.Models
{
    public class Brand
    {
        [Key]
        public long BrandID { get; set; }
        public long BrandName { get; set; }
    }
}