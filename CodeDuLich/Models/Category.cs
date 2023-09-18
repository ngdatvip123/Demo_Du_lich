using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CodeDuLich.Models
{
    public class Category
    {
        [Key]
        public long CategoriesID { get; set; }
        public long CategoriesName { get; set; }
    }
}