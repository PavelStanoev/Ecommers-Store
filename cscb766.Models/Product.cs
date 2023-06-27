using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace cscb766.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Product Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        [DisplayName("List Price")]
        public double ListPrice { get; set; }
        [Required]
        [DisplayName("Price with discount")]
        public double DiscountPrice { get; set; }


        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }







    }
}
