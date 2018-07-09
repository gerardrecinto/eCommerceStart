using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceStart.Models
{
    public class Product
    {
        public Product()
        {
        }
        public int Id
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Product name is required")]
        [MaxLength(45, ErrorMessage = = "Max Length 45 characters only")]
        public string Name
        {
            get;
            set;
        }

        [RegularExpression(@"^\d+.\d{0,2}$",ErrorMessage = "Must be decimal with 2 decimal pts")]
        [Range(0,5,ErrorMessage = "The max possible price should be up to 5 digits")]
        public Decimal Price
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        [Display(Name = "Updated At")]
        [Column(TypeName = "datetime2")]
        public DateTime LastUpdated
        {
            get;
            set;
        }

        public int CategoryId
        {
            get;
            set;
        }

        public virtual Category Category
        {
            get;
            set;
        }

        public virtual ICollection<OrderedProduct> OrderedProducts
        {
            get;
            set;
        }
    }
}
